﻿namespace Twenty2.Schedule.Api.Entities;

public class WorkerAvailability
{
    public long Id { get; set; }

    public Worker? Worker { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<Work>? AvailableWorks { get; set; }
}
