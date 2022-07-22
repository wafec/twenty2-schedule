using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class WorkDao : SkeletalDao<Work>, IWorkDao
{
    public WorkDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

