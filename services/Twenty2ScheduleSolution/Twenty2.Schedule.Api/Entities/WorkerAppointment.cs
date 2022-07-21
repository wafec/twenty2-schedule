namespace Twenty2.Schedule.Api.Entities;

public class WorkerAppointment : IEntity
{
    public long Id { get; set; }

    public long WorkerId { get; set; }

    public Worker? Worker { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<Work>? SelectedWorks { get; set; }

    public long UserId { get; set; }

    public User? User { get; set; }

    public bool Concluded { get; set; }
}