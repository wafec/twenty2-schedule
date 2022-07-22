using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkRequestEntityTypeConfiguration : IEntityTypeConfiguration<WorkRequest>
{
    private static readonly string WORK_REQUEST_TABLE = "workrequests";
    private static readonly string WORK_REQUEST_WORK_TABLE = "workrequest_works";

    public void Configure( EntityTypeBuilder<WorkRequest> builder )
    {
        builder.ToTable( WORK_REQUEST_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd().HasColumnName( "id" );
        builder.Property( x => x.StartDate ).IsRequired().HasColumnName( "start_date" );
        builder.Property( x => x.Accepted ).HasColumnName( "accepted" ).HasDefaultValue( false );
        builder.Property( x => x.Confirmed ).HasColumnName( "confirmed" ).HasDefaultValue( false );
        builder.Property( x => x.UserId ).HasColumnName( "user_id" );
        builder.HasMany( x => x.Works ).WithMany( x => x.WorkRequests )
            .UsingEntity<WorkRequestWork>( j => j
                    .HasOne( x => x.Work )
                    .WithMany( x => x.WorkRequestWorks )
                    .HasForeignKey( x => x.WorkId ),
                j => j
                    .HasOne( x => x.WorkRequest )
                    .WithMany( x => x.WorkRequestWorks )
                    .HasForeignKey( x => x.WorkRequestId ),
                j =>
                {
                    j.ToTable( WORK_REQUEST_WORK_TABLE );
                    j.Property( x => x.WorkId ).HasColumnName( "work_id" );
                    j.Property( x => x.WorkRequestId ).HasColumnName( "work_request_id" );
                } );
                
    }
}
