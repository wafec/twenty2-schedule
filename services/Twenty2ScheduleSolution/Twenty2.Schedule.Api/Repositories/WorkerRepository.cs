namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class WorkerRepository : SkeletalRepository<Worker>, IWorkerRepository
{
    public WorkerRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

