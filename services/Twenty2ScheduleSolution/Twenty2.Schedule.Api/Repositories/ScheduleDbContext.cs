namespace Twenty2.Schedule.Api.Repositories;

using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Entities;

public class ScheduleDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public DbSet<Work>? Works { get; set; }

    public DbSet<Worker>? Workers { get; set; }

    public DbSet<WorkerAppointment>? WorkerAppointments { get; set; }

    public DbSet<WorkerAvailability>? WorkerAvailabilityList { get; set; }

    public DbSet<WorkRequest>? WorkRequests { get; set; }

    public ScheduleDbContext()
    {
    }
}

