namespace Twenty2.Schedule.Api.Entities;

public class Work : IEntity
{
    public long Id { get; set; }

    public TimeSpan AssuredCompletion { get; set; }

    public TimeSpan CalculatedCompletion { get; set; }

    public long WorkerId { get; set; }

    public Worker? Worker { get; set; }

    public ICollection<WorkerAppointment>? WorkerAppointments { get; set; }

    public List<WorkerAppointmentWork>? WorkerAppointmentWorks { get; set; }
}

