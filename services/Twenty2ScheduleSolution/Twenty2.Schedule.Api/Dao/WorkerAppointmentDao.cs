using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao;

public class WorkerAppointmentDao : SkeletalDao<WorkerAppointment>, IWorkerAppointmentDao
{
    public WorkerAppointmentDao( ScheduleContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

