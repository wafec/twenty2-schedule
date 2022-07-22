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
                });
    }
}
