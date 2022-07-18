namespace Twenty2.Schedule.Api.Entities;

public class WorkerAppointment
{
    public long Id { get; set; }

    public Worker? Worker { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<Work>? SelectedWorks { get; set; }

    public User? User { get; set; }

    public bool Concluded { get; set; }
}