namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class UserRepository : SkeletalRepository<User>, IUserRepository
{
    public UserRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
        
    }
}

