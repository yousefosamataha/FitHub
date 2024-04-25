using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityCategoryRepository;
public class ActivityCategoryService : BaseRepository<ActivityCategoryEntity>, IActivityCategoryService
{
    private readonly ApplicationDbContext _context;

    public ActivityCategoryService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ActivityCategoryDTO> GetByIdAsync(int id)
    {
        ActivityCategoryEntity entity = await base.GetByIdAsync(id);

        return entity.ToDTO();
    }
}
