namespace Twenty2.Schedule.Api.Entities;

public class Work : IEntity
{
    public long Id { get; set; }

    public TimeSpan? AssuredCompletion { get; set; }

    public TimeSpan? CalculatedCompletion { get; set; }

    public long WorkerId { get; set; }

    public Worker? Worker { get; set; }

    public List<WorkerAppointment>? WorkerAppointments { get; set; }

    public List<WorkerAppointmentWork>? WorkerAppointmentWorks { get; set; }

    public List<WorkerAvailability>? WorkerAvailabilities { get; set; }

    public List<WorkerAvailabilityWork>? WorkerAvailabilityWorks { get; set; }

    public List<WorkRequest>? WorkRequests { get; set; }

    public List<WorkRequestWork>? WorkRequestWorks { get; set; }
}

