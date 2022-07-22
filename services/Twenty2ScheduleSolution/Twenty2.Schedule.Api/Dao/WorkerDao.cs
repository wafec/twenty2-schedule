using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class WorkerDao : SkeletalDao<Worker>, IWorkerDao
{
    public WorkerDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

