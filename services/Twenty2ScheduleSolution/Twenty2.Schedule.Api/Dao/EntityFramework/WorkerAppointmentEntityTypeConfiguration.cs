using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkerAppointmentEntityTypeConfiguration :
    IEntityTypeConfiguration<WorkerAppointment>
{
    public void Configure( EntityTypeBuilder<WorkerAppointment> builder )
    {
        builder.HasOne( x => x.Worker ).WithMany().HasForeignKey( x => x.WorkerId );
        builder.HasMany( x => x.Works ).WithMany( x => x.WorkerAppointments )
            .UsingEntity<WorkerAppointmentWork>( j => j
                    .HasOne( ww => ww.Work)
                    .WithMany( w => w.WorkerAppointmentWorks )
                    .HasForeignKey( ww => ww.WorkId ),
                j => j
                    .HasOne( ww => ww.WorkerAppointment )
                    .WithMany( w => w.WorkerAppointmentWorks )
                    .HasForeignKey( ww => ww.WorkerAppointmentId ),
                j =>
                {
                    j.ToTable( "workerappointment_works" );
                });
    }
}
