using gms.common.Models.GymCat.GymNotification;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.service.Hubs;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymNotificationRepository;

public class GymNotificationService : BaseRepository<GymNotificationEntity>, IGymNotificationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<GymNotificationService> _logger;
    private readonly IHubContext<NotificationHub> _hubContext;

    public GymNotificationService
    (
        ApplicationDbContext context,
        IHttpContextAccessor httpContextAccessor,
        ILogger<GymNotificationService> logger,
        IHubContext<NotificationHub> hubContext
    ) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
        _hubContext = hubContext;
    }

    public async Task<GymNotificationDTO> CreateGymNotificationAsync(CreateGymNotificationDTO newGymNotification)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(CreateGymNotificationAsync), DateTime.Now.ToString() });

            GymNotificationEntity newGymNotificationEntity = newGymNotification.ToEntity();

            await AddAsync(newGymNotificationEntity);

            return newGymNotificationEntity.ToDTO();
        }

    }

    public async Task<GymNotificationDTO> UpdateGymNotificationAsync(UpdateGymNotificationDTO updateGymNotificationDTO)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(UpdateGymNotificationAsync), DateTime.Now.ToString() });

            GymNotificationEntity oldGymNotificationEntity = await FindAsync(gn => gn.Id == updateGymNotificationDTO.Id);

            oldGymNotificationEntity = updateGymNotificationDTO.ToUpdatedEntity(oldGymNotificationEntity);

            await UpdateAsync(oldGymNotificationEntity);

            return oldGymNotificationEntity.ToDTO();
        }

    }

    public async Task<bool> DeleteGymNotificationAsync(int gymNotificationId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(DeleteGymNotificationAsync), DateTime.Now.ToString() });

            GymNotificationEntity gymNotificationEntity = await FindAsync(gn => gn.Id == gymNotificationId && gn.BranchId == GetBranchId());

            await DeleteAsync(gymNotificationEntity);

            return true;
        }
    }

    public async Task<GymNotificationDTO> GetGymNotificationByIdAsync(int gymNotificationId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(GetGymNotificationByIdAsync), DateTime.Now.ToString() });

            GymNotificationEntity gymNotificationEntity = await FindAsync(gn => gn.Id == gymNotificationId && gn.BranchId == GetBranchId());

            return gymNotificationEntity.ToDTO();
        }
    }

    public async Task<List<GymNotificationDTO>> GetGymNotificationListForGymAsync()
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(GetGymNotificationListForGymAsync), DateTime.Now.ToString() });


            List<GymNotificationDTO> result = (await FindAllAsync(gn => gn.GymBranch.GymId == GetGymId())).Select(gn => gn.ToDTO()).ToList();

            return result;
        }
    }

    public async Task<List<GymNotificationDTO>> GetGymNotificationListForBranchAsync()
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(GetGymNotificationListForBranchAsync), DateTime.Now.ToString() });


            List<GymNotificationDTO> result = (await FindAllAsync(gn => gn.BranchId == GetBranchId())).Select(gn => gn.ToDTO()).ToList();

            return result;
        }
    }

    public async Task<List<GymNotificationDTO>> GetGymNotificationListByUserIdAsync(int userId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(GetGymNotificationListByUserIdAsync), DateTime.Now.ToString() });


            List<GymNotificationDTO> result = (await FindAllAsync(gn => gn.GymReceiverUserId == userId)).Select(gn => gn.ToDTO()).ToList();

            return result;
        }
    }

    public async Task<List<GymNotificationDTO>> GetGymNotificationListForLoggedinUserAsync()
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(GymNotificationService), nameof(GetGymNotificationListByUserIdAsync), DateTime.Now.ToString() });


            List<GymNotificationDTO> result = (await FindAllAsync(gn => gn.GymReceiverUserId == GetUserId())).Select(gn => gn.ToDTO()).ToList();

            return result;
        }
    }

}
