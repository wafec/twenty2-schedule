using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twenty2.Schedule.Api.Entities;

namespace Twenty2.Schedule.Api.Dao.EntityFramework;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    private static readonly string USER_TABLE = "users";

    public void Configure( EntityTypeBuilder<User> builder )
    {
        builder.ToTable( USER_TABLE );
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
    }
}
