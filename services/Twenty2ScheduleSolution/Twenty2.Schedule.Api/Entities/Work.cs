namespace Twenty2.Schedule.Api.Entities;

public class Work : IEntity
{
    public long Id { get; set; }

    public TimeSpan AssuredCompletion { get; set; }

    public TimeSpan CalculatedCompletion { get; set; }

    public Worker? Worker { get; set; }
}

