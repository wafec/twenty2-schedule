using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class WorkEntityTypeConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure( EntityTypeBuilder<Work> builder )
    {
        builder.HasOne( x => x.Worker ).WithMany().HasForeignKey( x => x.WorkerId );
    }
}
