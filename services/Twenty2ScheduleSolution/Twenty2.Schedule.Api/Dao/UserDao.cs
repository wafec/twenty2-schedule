using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class UserDao : SkeletalDao<User>, IUserDao
{
    public UserDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
        
    }
}

