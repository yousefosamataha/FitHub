﻿using gms.common.Models.GymCat.GymLocation;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymLocationRepository;

public class GymLocationService : BaseRepository<GymLocationEntity>, IGymLocationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymLocationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<bool> CreateNewGymLocationAsync(CreateGymLocationDTO createGymLocationModal)
    {
        GymLocationEntity gymLocationEntity = createGymLocationModal.ToEntity();
        gymLocationEntity.BranchId = GetBranchId();
        await AddAsync(gymLocationEntity);
        return true;
    }

    public async Task<List<GymLocationDTO>> GetGymLocationsListAsync()
    {
        List<GymLocationEntity> listOfGymLocations = await FindAllAsync(gl => gl.BranchId == GetBranchId());
        return listOfGymLocations.Select(gl => gl.ToDTO()).ToList();
    }

    public async Task<bool> DeleteGymLocationAsync(int gymLocationId)
    {
        GymLocationEntity gymLocationEntity = await FindAsync(gl => gl.Id == gymLocationId && gl.BranchId == GetBranchId());
        await DeleteAsync(gymLocationEntity);
        return true;
    }
}