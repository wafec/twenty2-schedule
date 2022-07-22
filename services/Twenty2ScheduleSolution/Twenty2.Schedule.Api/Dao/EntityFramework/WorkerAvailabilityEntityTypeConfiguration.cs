using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkerAvailabilityEntityTypeConfiguration : IEntityTypeConfiguration<WorkerAvailability>
{
    private readonly static string WORKER_AVAILABILITY_TABLE = "workeravailabilities";
    private readonly static string WORKER_AVAILABILITY_WORKS_TABLE = "workeravailability_works";

    public void Configure( EntityTypeBuilder<WorkerAvailability> builder )
    {
        builder.ToTable( WORKER_AVAILABILITY_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
        builder.Property( x => x.StartDate ).IsRequired();
        builder.Property( x => x.EndDate ).IsRequired();
        builder.HasMany( wa => wa.Works ).WithMany( w => w.WorkerAvailabilities )
            .UsingEntity<WorkerAvailabilityWork>( j => j
                    .HasOne( x => x.Work )
                    .WithMany( x => x.WorkerAvailabilityWorks )
                    .HasForeignKey( x => x.WorkId ),
                j => j
                    .HasOne( x => x.WorkerAvailability )
                    .WithMany( x => x.WorkerAvailabilityWorks )
                    .HasForeignKey( x => x.WorkerAvailabilityId ),
                j =>
                {
                    j.ToTable( WORKER_AVAILABILITY_WORKS_TABLE );
                } );
    }
}

