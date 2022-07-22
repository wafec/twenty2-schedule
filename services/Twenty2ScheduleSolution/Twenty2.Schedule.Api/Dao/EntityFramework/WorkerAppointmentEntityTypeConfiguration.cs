using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkerAppointmentEntityTypeConfiguration :
    IEntityTypeConfiguration<WorkerAppointment>
{
    private readonly static string WORKER_APPOINTMENT_TABLE = "workerappointments";
    private readonly static string WORKER_APPOINTMENT_WORKS_TABLE = "workerappointment_works";

    public void Configure( EntityTypeBuilder<WorkerAppointment> builder )
    {
        builder.ToTable( WORKER_APPOINTMENT_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd().HasColumnName( "id" );
        builder.Property( x => x.StartDate )
            .IsRequired()
            .HasColumnName( "start_date" );
        builder.Property( x => x.EndDate )
            .IsRequired()
            .HasColumnName( "end_date" );
        builder.Property( x => x.WorkerId )
            .HasColumnName( "worker_id" );
        builder.Property( x => x.UserId )
            .HasColumnName( "user_id" );
        builder.Property( x => x.Concluded )
            .HasColumnName( "concluded" );
        builder.HasOne( x => x.User ).WithMany().HasForeignKey( x => x.UserId );
        builder.HasOne( x => x.Worker ).WithMany().HasForeignKey( x => x.WorkerId );
        builder.HasMany( x => x.Works ).WithMany( x => x.WorkerAppointments )
            .UsingEntity<WorkerAppointmentWork>( j => j
                    .HasOne( x => x.Work)
                    .WithMany( x => x.WorkerAppointmentWorks )
                    .HasForeignKey( x => x.WorkId ),
                j => j
                    .HasOne( x => x.WorkerAppointment )
                    .WithMany( x => x.WorkerAppointmentWorks )
                    .HasForeignKey( x => x.WorkerAppointmentId ),
                j =>
                {
                    j.ToTable( WORKER_APPOINTMENT_WORKS_TABLE );
                    j.Property( x => x.WorkId ).HasColumnName( "work_id" );
                    j.Property( x => x.WorkerAppointmentId ).HasColumnName( "worker_appointment_id" );
                });
    }
}
