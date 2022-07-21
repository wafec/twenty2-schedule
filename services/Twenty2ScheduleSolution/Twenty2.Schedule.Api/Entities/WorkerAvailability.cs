namespace Twenty2.Schedule.Api.Entities;

public class WorkerAvailability : IEntity
{
    public long Id { get; set; }

    public long WorkerId { get; set; }

    public Worker? Worker { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<Work>? AvailableWorks { get; set; }
}
