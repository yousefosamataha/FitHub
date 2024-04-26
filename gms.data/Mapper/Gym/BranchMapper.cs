using gms.common.Models.GymCat.Branch;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class BranchMapper
{
    public static GymBranchEntity ToEntity(this CreateBranchDTO source)
    {
        return new GymBranchEntity()
        {
            GymId = source.GymId,
            BranchName = source.BranchName,
            Address = source.Address,
            ContactNumber = source.ContactNumber,
            CountryId = source.CountryId,
            Email = source.Email,
            IsMainBranch = source.IsMainBranch,
        };
    }

    public static BranchDTO ToDTO(this GymBranchEntity source)
    {
        return new BranchDTO()
        {
            Id = source.Id,
            GymId = source.GymId,
            BranchName = source.BranchName,
            Address = source.Address,
            ContactNumber = source.ContactNumber,
            CountryId = source.CountryId,
            Email = source.Email,
            IsMainBranch = source.IsMainBranch,
        };
    }
}
