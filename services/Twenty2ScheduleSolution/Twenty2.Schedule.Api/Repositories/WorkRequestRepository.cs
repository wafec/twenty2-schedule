namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class WorkRequestRepository : SkeletalRepository<WorkRequest>, IWorkRequestRepository
{
    public WorkRequestRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

