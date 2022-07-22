using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class ScheduleContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public DbSet<Work>? Works { get; set; }

    public DbSet<Worker>? Workers { get; set; }

    public DbSet<WorkerAppointment>? WorkerAppointments { get; set; }

    public DbSet<WorkerAvailability>? WorkerAvailabilityList { get; set; }

    public DbSet<WorkRequest>? WorkRequests { get; set; }

    public ScheduleContext(DbContextOptions<ScheduleContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        modelBuilder.ApplyConfigurationsFromAssembly( typeof( ScheduleContext ).Assembly );
    }
}

