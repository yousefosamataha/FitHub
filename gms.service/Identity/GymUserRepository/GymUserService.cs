using gms.common.Enums;
using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.Models.SharedCat;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace gms.service.Identity.GymUserRepository;
public class GymUserService : IGymUserService
{
	private readonly UserManager<GymUserEntity> _userManager;
	private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public GymUserService(
		UserManager<GymUserEntity> userManager,
		RoleManager<GymIdentityRoleEntity> roleManager,
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor)
	{
		_userManager = userManager;
		_roleManager = roleManager;
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public int GetUserId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("UserId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetBranchId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("BranchId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetGymId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("GymId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public async Task<List<GymUserDTO>> GetAllGymUserByGymIdAsync(int gymId)
	{
		List<GymUserEntity> gymUsersEntities = await _userManager.Users.Where(u => u.GymBranch.GymId == gymId).ToListAsync();

		List<GymUserDTO> gymUsers = new();

		foreach (GymUserEntity user in gymUsersEntities)
		{
			IList<string> roles = await _userManager.GetRolesAsync(user);
			GymUserDTO gymUserDto = user.ToDTO();
			gymUserDto.Roles = string.Join(" , ", roles);
		}
		return gymUsers;
	}

	public async Task<List<GymUserDTO>> GetAllGymBranchUsersByBranchIdAsync(int gymId, int branchId)
	{
		List<GymUserEntity> gymUsersEntities = await _userManager.Users.Where(u => u.GymBranch.GymId == gymId && u.GymBranch.Id == branchId).ToListAsync();

		List<GymUserDTO> gymUsers = new();

		foreach (GymUserEntity user in gymUsersEntities)
		{
			IList<string> roles = await _userManager.GetRolesAsync(user);
			GymUserDTO gymUserDto = user.ToDTO();
			gymUserDto.Roles = string.Join(" , ", roles);
		}
		return gymUsers;
	}

	public async Task<GymUserRolesDTO> GetUserRolesByUserIdAsync(int userId)
	{
		GymUserEntity user = await _userManager.FindByIdAsync(userId.ToString());

		if (user is null)
			return new GymUserRolesDTO();

		List<GymIdentityRoleEntity> roles = await _roleManager.Roles.ToListAsync();

		GymUserRolesDTO gymuserRolesViewModel = new()
		{
			UserId = userId,
			UserName = user.UserName,
			Email = user.Email,
			Roles = roles.Select(r => new SelectItemDTO()
			{
				Text = r.Name,
				IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
			}).ToList()
		};
		return gymuserRolesViewModel;
	}

	public async Task<GymUserRolesDTO> UpdateGymUserRolesAsyn(UpdateGymUserRolesDTO gymUserRoles)
	{
		GymUserEntity user = await _userManager.FindByEmailAsync(gymUserRoles.UserEmail);
		if (user is null)
			return new GymUserRolesDTO();

		IList<string> userRoles = await _userManager.GetRolesAsync(user);

		await _userManager.RemoveFromRolesAsync(user, userRoles);

		await _userManager.AddToRolesAsync(user, gymUserRoles.Roles.Where(role => role.IsSelected).Select(role => role.Text));

		List<GymIdentityRoleEntity> roles = await _roleManager.Roles.ToListAsync();

		GymUserRolesDTO updatedGymUserRolesViewModel = new()
		{
			UserId = user.Id,
			UserName = user.UserName,
			Email = user.Email,
			Roles = roles.Select(r => new SelectItemDTO()
			{
				Text = r.Name,
				IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
			}).ToList()
		};

		return updatedGymUserRolesViewModel;
	}

	public async Task<GymUserEntity> GetGymUserByEmail(string email)
	{
		GymUserEntity? entity = await _context.Users
											  .Include(u => u.GymBranch)
											  .ThenInclude(gb => gb.Gym)
											  .FirstOrDefaultAsync(u => string.Equals(u.Email.ToLower().Trim(), email.ToLower().Trim()));
		return entity;
	}

	public async Task<GymUserDTO> UpdateGymUser(GymUserEntity entity)
	{
		_context.Users.Update(entity);
		await _context.SaveChangesAsync();
		return entity.ToDTO();
	}


    #region Member
    public async Task<GymUserDTO> CreateNewGymMemberUserAsync(CreateGymUserDTO entity, int branchId)
	{
		GymUserEntity gymUserEntity = entity.ToEntity();
		gymUserEntity.BranchId = branchId;
		gymUserEntity.EmailConfirmed = true;
		gymUserEntity.GymUserTypeId = GymUserTypeEnum.Member;
		gymUserEntity.StatusId = StatusEnum.InActive;
        IdentityResult result = await _userManager.CreateAsync(gymUserEntity, entity.Password);
        await _userManager.AddToRoleAsync(gymUserEntity, RolesEnum.Member.ToString());
        GymUserEntity createdUser = await GetGymUserByEmail(entity.Email);
		return createdUser.ToDTO();
	}

	public async Task<List<GymUserDTO>> GetGymMemberUsersListAsync()
	{
		List<GymUserEntity> listOfMembers = await _context.Users
											  .Include(u => u.GymMemberMemberships)
											  .Where(u => u.BranchId == GetBranchId() && u.GymUserTypeId == GymUserTypeEnum.Member).ToListAsync();

		return listOfMembers.Select(u => u.ToDTO()).ToList();
	}

	#endregion

}
