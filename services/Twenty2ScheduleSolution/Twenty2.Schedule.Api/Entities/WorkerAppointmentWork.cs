namespace Twenty2.Schedule.Api.Entities;

public class WorkerAppointmentWork
{
    public long WorkerAppointmentId { get; set; }

    public WorkerAppointment? WorkerAppointment { get; set; }

    public long WorkId { get; set; }

    public Work? Work { get; set; }
}
