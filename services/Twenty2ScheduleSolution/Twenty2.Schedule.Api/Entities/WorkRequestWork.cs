namespace Twenty2.Schedule.Api.Entities;

public class WorkRequestWork
{
    public long WorkRequestId { get; set; }

    public WorkRequest? WorkRequest { get; set; }

    public long WorkId { get; set; }

    public Work? Work { get; set; }
}

