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
        builder.Property( x => x.Id ).ValueGeneratedOnAdd().HasColumnName( "id" );
        builder.Property( x => x.StartDate ).IsRequired().HasColumnName( "start_date" );
        builder.Property( x => x.EndDate ).IsRequired().HasColumnName( "end_date" );
        builder.Property( x => x.WorkerId ).HasColumnName( "worker_id" );
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
                    j.Property( x => x.WorkId ).HasColumnName( "work_id" );
                    j.Property( x => x.WorkerAvailabilityId ).HasColumnName( "work_availability_id" );
                } );
    }
}

