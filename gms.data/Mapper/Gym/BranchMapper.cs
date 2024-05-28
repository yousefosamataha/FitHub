using gms.common.Models.GymCat.Branch;
using gms.data.Mapper.Shared;
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
            GeneralSettingId = source.GeneralSettingId,
            CreatedById = source.CreatedById,
        };
    }

    public static GymBranchDTO ToDTO(this GymBranchEntity source)
    {
        return new GymBranchDTO()
        {
            Id = source.Id,
            GymId = source.GymId,
            BranchName = source.BranchName,
            Address = source.Address,
            ContactNumber = source.ContactNumber,
            CountryId = source.CountryId,
            Email = source.Email,
            IsMainBranch = source.IsMainBranch,
            GeneralSettingId = source.GeneralSettingId,
			CreatedById = source.CreatedById,
            Country = source.Country?.ToDTO(),
            GeneralSetting = source.GeneralSetting?.ToDTO()
		};
    }

	public static GymBranchEntity ToUpdatedEntity(this GymBranchDTO source, GymBranchEntity entity)
	{
		entity.BranchName = !string.IsNullOrWhiteSpace(source.BranchName) && !string.Equals(source.BranchName, entity.BranchName, StringComparison.OrdinalIgnoreCase) ? source.BranchName : entity.BranchName;
		entity.Address = !string.IsNullOrWhiteSpace(source.Address) && !string.Equals(source.Address, entity.Address, StringComparison.OrdinalIgnoreCase) ? source.Address : entity.Address;
		entity.ContactNumber = !string.IsNullOrWhiteSpace(source.ContactNumber) && !string.Equals(source.ContactNumber, entity.ContactNumber, StringComparison.OrdinalIgnoreCase) ? source.ContactNumber : entity.ContactNumber;
		entity.CountryId = source.CountryId;
		entity.Email = !string.IsNullOrWhiteSpace(source.Email) && !string.Equals(source.Email, entity.Email, StringComparison.OrdinalIgnoreCase) ? source.Email : entity.Email;
		entity.IsMainBranch = source.IsMainBranch;
		entity.GeneralSettingId = source.GeneralSettingId > default(int) && source.GeneralSettingId != entity.GeneralSettingId ? source.GeneralSettingId : entity.GeneralSettingId;
		entity.CreatedById = source.CreatedById > default(int) && source.CreatedById != entity.CreatedById ? source.CreatedById : entity.CreatedById;

		return entity;
	}
}
