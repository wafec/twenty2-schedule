namespace Twenty2.Schedule.Tests.Api.Repositories;

using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Entities;
using Twenty2.Schedule.Api.Repositories;
using Xunit;

public class SkeletalRepositoryTest
{
    private ScheduleDbContext context;
    private WorkRepository workRepository;

    public SkeletalRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<ScheduleDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        context = new ScheduleDbContext( options );
        workRepository = new WorkRepository( context );
    }

    [Fact]
    async void Add_WhenNew_ShouldAdd()
    {
        var work = new Work() { Id = 0 };
        
        var result = await workRepository.Add( work );
        var hasSaved = await workRepository.SaveChanges();

        Assert.True( hasSaved );
        Assert.Equal( 1, result.Id );
    }

    [Fact]
    async void Delete_WhenTheRecordExists_ShouldRemove()
    {
        await workRepository.Add( new Work() );
        await workRepository.SaveChanges();

        var result = await workRepository.Delete( 1 );
        var hasDeleted = await workRepository.SaveChanges();

        Assert.True( hasDeleted );
        Assert.Empty( context.Works );
    }
}
