namespace Twenty2.Schedule.Api.Entities;

public class WorkRequest : IEntity
{
    public long Id { get; set; }

    public User? User { get; set; }

    public List<Work>? WantedWorks { get; set; }

    public bool Accepted { get; set; }

    public bool Confirmed { get; set; }

    public DateTime StartDate { get; set; }
}

