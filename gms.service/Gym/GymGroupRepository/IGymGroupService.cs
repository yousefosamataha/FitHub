﻿using gms.common.Models.GymCat.GymGroup;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymGroupRepository;

public interface IGymGroupService : IBaseRepository<GymGroupEntity>
{
	Task<GymGroupDTO> AddGymGroupAsync(CreateGymGroupDTO entity);
	Task<List<GymGroupDTO>> GetGymGroupsListAsync(int branchId);
}