using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkerEntityTypeConfiguration : IEntityTypeConfiguration<Worker>
{
    private static readonly string WORKER_TABLE = "workers";

    public void Configure( EntityTypeBuilder<Worker> builder )
    {
        builder.ToTable( WORKER_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
    }
}

