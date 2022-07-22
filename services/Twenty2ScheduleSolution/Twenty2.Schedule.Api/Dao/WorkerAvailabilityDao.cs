using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class WorkerAvailabilityDao : SkeletalDao<WorkerAvailability>, IWorkerAvailabilityDao
{
    public WorkerAvailabilityDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

