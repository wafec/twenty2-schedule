namespace Twenty2.Schedule.Api.Entities;

public class WorkerAvailabilityWork
{
    public long WorkerAvailabilityId { get; set; }

    public WorkerAvailability? WorkerAvailability { get; set; }

    public long WorkId { get; set; }

    public Work? Work { get; set; }
}

