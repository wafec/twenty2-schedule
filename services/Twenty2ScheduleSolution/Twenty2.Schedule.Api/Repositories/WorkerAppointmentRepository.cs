namespace Twenty2.Schedule.Api.Repositories;

using Twenty2.Schedule.Api.Entities;

public class WorkerAppointmentRepository : SkeletalRepository<WorkerAppointment>, IWorkerAppointmentRepository
{
    public WorkerAppointmentRepository( ScheduleDbContext scheduleDbContext ) : base( scheduleDbContext )
    {
    }
}

