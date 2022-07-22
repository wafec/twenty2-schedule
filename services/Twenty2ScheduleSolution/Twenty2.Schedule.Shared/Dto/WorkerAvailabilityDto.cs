namespace Twenty2.Schedule.Shared.Dto;

public class WorkerAvailabilityDto
{
    public long Id { get; set; }

    public long WorkerId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}