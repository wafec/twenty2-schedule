namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class WorkerAvailabilityRepository : SkeletalRepository<WorkerAvailability>
{
    public WorkerAvailabilityRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

