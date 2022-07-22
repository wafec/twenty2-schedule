using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class WorkRequestDao : SkeletalDao<WorkRequest>, IWorkRequestDao
{
    public WorkRequestDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

