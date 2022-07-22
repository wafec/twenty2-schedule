namespace Twenty2.Schedule.Api.Entities;

public class Worker : IEntity
{
    public long Id { get; set; }

    public long WorkerId { get; set; }
}