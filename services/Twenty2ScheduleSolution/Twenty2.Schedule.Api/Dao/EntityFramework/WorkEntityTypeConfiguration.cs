using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkEntityTypeConfiguration : IEntityTypeConfiguration<Work>
{
    private static readonly string WORK_TABLE = "works";

    public void Configure( EntityTypeBuilder<Work> builder )
    {
        builder.ToTable( WORK_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id )
            .ValueGeneratedOnAdd()
            .HasColumnName( "id" );
        builder.Property( x => x.AssuredCompletion )
            .HasColumnName( "assured_completion" )
            .IsRequired();
        builder.Property( x => x.CalculatedCompletion )
            .HasColumnName( "calculated_completion" );
        builder.Property( x => x.WorkerId )
            .HasColumnName( "worker_id" );
        builder.HasOne( x => x.Worker ).WithMany().HasForeignKey( x => x.WorkerId );
    }
}
