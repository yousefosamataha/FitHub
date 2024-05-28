using gms.common.Enums;
using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.Models.IdentityCat.User;
using gms.common.Models.SharedCat;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;

namespace gms.service.Identity.GymUserRepository;
public class GymUserService : IGymUserService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly UserManager<GymUserEntity> _userManager;
	private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
	private readonly ILogger<GymUserService> _logger;
	public GymUserService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		UserManager<GymUserEntity> userManager,
		RoleManager<GymIdentityRoleEntity> roleManager,
		ILogger<GymUserService> logger
	)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_userManager = userManager;
		_roleManager = roleManager;
		_logger = logger;
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

	public Dictionary<string, object> GetScopesInformation()
	{
		Dictionary<string, object> scopeInfo = new();
		scopeInfo.Add("MachineName", Environment.MachineName);
		scopeInfo.Add("Environment", "Development");
		scopeInfo.Add("AppName", "Logging Scopes");
		scopeInfo.Add("GymId", GetGymId());
		scopeInfo.Add("BranchId", GetBranchId());
		scopeInfo.Add("UserId", GetUserId());
		return scopeInfo;
	}
	public async Task<List<GymUserDTO>> GetAllGymUserByGymIdAsync(int gymId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetAllGymUserByGymIdAsync), DateTime.Now.ToString() });

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
		
	}

	public async Task<List<GymUserDTO>> GetAllGymBranchUsersByBranchIdAsync(int gymId, int branchId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetAllGymBranchUsersByBranchIdAsync), DateTime.Now.ToString() });

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
		
	}

	public async Task<GymUserRolesDTO> GetUserRolesByUserIdAsync(int userId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetUserRolesByUserIdAsync), DateTime.Now.ToString() });

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
		
	}

	public async Task<GymUserRolesDTO> UpdateGymUserRolesAsyn(UpdateGymUserRolesDTO gymUserRoles)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(UpdateGymUserRolesAsyn), DateTime.Now.ToString() });

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
		
	}

	public async Task<GymUserEntity> GetGymUserByEmail(string email)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetGymUserByEmail), DateTime.Now.ToString() });

			GymUserEntity? entity = await _context.Users
												  .Include(u => u.GymBranch)
												  .ThenInclude(gb => gb.Gym)
												  .FirstOrDefaultAsync(u => string.Equals(u.Email.ToLower().Trim(), email.ToLower().Trim()));
			return entity;
		}
		
	}

    public async Task<GymUserEntity> GetGymUserByIdAsync(int userId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetGymUserByIdAsync), DateTime.Now.ToString() });

			GymUserEntity? entity = await _context.Users
												  .Include(u => u.GymBranch)
												  .ThenInclude(gb => gb.Gym)
												  .FirstOrDefaultAsync(u => u.Id == userId);
			return entity;
		}
		
    }

    public async Task<GymUserDTO> UpdateGymUser(GymUserEntity entity)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(UpdateGymUser), DateTime.Now.ToString() });

			_context.Users.Update(entity);
			await _context.SaveChangesAsync();
			return entity.ToDTO();
		}
		
	}

    #region Member
    public async Task<GymUserDTO> CreateNewGymMemberUserAsync(CreateGymUserDTO entity, int branchId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(CreateNewGymMemberUserAsync), DateTime.Now.ToString() });

			GymUserEntity gymUserEntity = entity.ToEntity();
			gymUserEntity.BranchId = branchId;
			gymUserEntity.EmailConfirmed = true;
			gymUserEntity.GymUserTypeId = GymUserTypeEnum.Member;
			gymUserEntity.StatusId = StatusEnum.InActive;
			IdentityResult result = await _userManager.CreateAsync(gymUserEntity, entity.Password);
			await _userManager.AddToRoleAsync(gymUserEntity, $"{GetBranchId()}_{RolesEnum.Member}");
			GymUserEntity createdUser = await GetGymUserByEmail(entity.Email);
			return createdUser.ToDTO();
		}
	}
	public async Task<List<GymUserDTO>> GetGymMemberUsersListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserService), nameof(GetGymMemberUsersListAsync), DateTime.Now.ToString() });

			List<GymUserEntity> listOfMembers = await _context.Users
															  .Include(u => u.GymMemberMemberships)
															  .ThenInclude(gmm => gmm.GymMembershipPlan)
															  .Where(u => u.BranchId == GetBranchId() && u.GymUserTypeId == GymUserTypeEnum.Member).ToListAsync();

		return listOfMembers.Select(u => u.ToDTO()).ToList();
	}

    public async Task<GymUserDTO> UpdateGymMemberUserAsync(UpdateGymUserDTO entity)
    {
        GymUserEntity currentUserData = await GetGymUserByEmail(entity.Email);
        GymUserEntity gymUserEntity = entity.ToUpdatedEntity(currentUserData);
		IdentityResult result = await _userManager.UpdateAsync(gymUserEntity);
		return gymUserEntity.ToDTO();
    }
	#endregion

	#region Staff
	public async Task<GymUserDTO> CreateNewGymStaffUserAsync(CreateGymUserDTO entity, int branchId, string RoleName)
	{
		GymUserEntity gymUserEntity = entity.ToEntity();
		gymUserEntity.BranchId = branchId;
		gymUserEntity.EmailConfirmed = true;
		gymUserEntity.GymUserTypeId = GymUserTypeEnum.Staff;
		IdentityResult result = await _userManager.CreateAsync(gymUserEntity, entity.Password);
		await _userManager.AddToRoleAsync(gymUserEntity, $"{GetBranchId()}_{RoleName}");
		GymUserEntity createdUser = await GetGymUserByEmail(entity.Email);
		return createdUser.ToDTO();
	}

	public async Task<List<GymUserDTO>> GetGymStaffUsersListAsync()
	{
		List<GymUserEntity> listOfStaffs = await _context.Users.Where(u => u.BranchId == GetBranchId() && u.GymUserTypeId == GymUserTypeEnum.Staff).ToListAsync();
		List<GymUserDTO> listOfStaffsDto = new ();
		foreach (var staff in listOfStaffs)
        {
			var staffRoles = await _userManager.GetRolesAsync(staff);
			listOfStaffsDto.Add(new GymUserDTO()
			{
				Id = staff.Id,
				BranchId = staff.BranchId,
				Image = staff.Image?.Length != 0 ? $"data:image/{staff.ImageTypeId?.ToString()};base64,{Convert.ToBase64String(staff.Image)}" : null,
				FirstName = staff.FirstName,
				LastName = staff.LastName,
				GenderId = staff.GenderId,
				BirthDate = staff.BirthDate,
				Address = staff.Address,
				City = staff.City,
				State = staff.State,
				PhoneNumber = staff.PhoneNumber,
				Email = staff.Email,
				Password = staff.PasswordHash,
				StatusId = staff.StatusId,
				RoleName = staffRoles?.FirstOrDefault()?.Split("_")[1],
				GymMemberGroups = staff.GymMemberGroups?.Select(gmg => gmg.ToDTO()).ToList()
			});
		}

        return listOfStaffsDto;
	}

	public async Task<GymUserDTO> UpdateGymStaffUserAsync(UpdateGymUserDTO entity, string RoleName)
	{
		GymUserEntity currentUserData = await GetGymUserByEmail(entity.Email);
		GymUserEntity gymUserEntity = entity.ToUpdatedEntity(currentUserData);
		IdentityResult result = await _userManager.UpdateAsync(gymUserEntity);

		var roles = await _userManager.GetRolesAsync(gymUserEntity);
		var removeRolesResult = await _userManager.RemoveFromRolesAsync(gymUserEntity, roles);
		if (removeRolesResult.Succeeded)
		{
			await _userManager.AddToRoleAsync(gymUserEntity, $"{GetBranchId()}_{RoleName}");
		}
		return gymUserEntity.ToDTO();
	}

	public async Task<bool> DeleteGymStaffUserAsync(int id, int branchId)
	{
		GymUserEntity currentUserEntity = await _context.Users.FirstOrDefaultAsync(u => u.Id == id && u.BranchId == branchId);
		currentUserEntity.IsDeleted = true;
		await _userManager.UpdateAsync(currentUserEntity);
		return true;
	}
	#endregion
}
