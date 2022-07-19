namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class WorkRepository : SkeletalRepository<Work>, IWorkRepository
{
    public WorkRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

