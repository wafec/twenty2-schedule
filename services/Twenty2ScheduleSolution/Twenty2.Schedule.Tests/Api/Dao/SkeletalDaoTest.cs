using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Dao;
using Twenty2.Schedule.Api.Dao.EntityFramework;
using Twenty2.Schedule.Api.Entities;
using Xunit;

namespace Twenty2.Schedule.Tests.Api.Repositories;

public class SkeletalDaoTest
{
    private ScheduleContext context;
    private WorkDao sut;

    public SkeletalDaoTest()
    {
        var options = new DbContextOptionsBuilder<ScheduleContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        context = new ScheduleContext( options );
        sut = new WorkDao( context );
    }

    [Fact]
    async void Add_WhenNew_ShouldAdd()
    {
        var work = new Work() { Id = 0 };
        
        var result = await sut.Add( work );
        var resultSaveChanges = await sut.SaveChanges();

        Assert.True( resultSaveChanges );
        Assert.Equal( 1, result.Id );
    }

    [Fact]
    async void Delete_WhenTheRecordExists_ShouldRemove()
    {
        var entity1 = await sut.Add( new Work() );
        var entity2 = await sut.Add( new Work() );
        await sut.SaveChanges();

        var resultDelete = await sut.Delete( entity1 );
        var resultSaveChanges = await sut.SaveChanges();

        Assert.True( resultDelete );
        Assert.True( resultSaveChanges );
        Assert.Single( context.Works );
        Assert.Equal( entity2, context.Works?.First() );
    }

    [Fact]
    async void Update_WhenTheRecordExists_ShouldUpdate()
    {
        await sut.Add( new Work() { AssuredCompletion = TimeSpan.Zero } );
        await sut.SaveChanges();

        var resultUpdate = await sut.Update( new Work() { Id = 1, AssuredCompletion = TimeSpan.MaxValue } );
        var resultSaveChanges = await sut.SaveChanges();

        Assert.Equal( TimeSpan.MaxValue, context.Find<Work>( 1L )?.AssuredCompletion );
        Assert.Equal( TimeSpan.MaxValue, resultUpdate.AssuredCompletion );
        Assert.True( resultSaveChanges );
    }

    [Fact]
    async void Get_WhenTheRecordExists_ShouldReturn()
    {
        await sut.Add( new Work() { Id = 2L, AssuredCompletion = TimeSpan.MaxValue } );
        await sut.SaveChanges();

        var resultGet = await sut.Get( 2L );

        Assert.NotNull( resultGet );
        Assert.Equal( 2L, resultGet?.Id );
        Assert.Equal( TimeSpan.MaxValue, resultGet?.AssuredCompletion );
    }

    [Fact]
    async void GetAll_WhenTheRecordsExist_ShouldReturn()
    {
        await sut.Add( new Work() );
        await sut.Add( new Work() );
        await sut.SaveChanges();

        var resultGetAll = await sut.GetAll();

        Assert.NotNull( resultGetAll );
        Assert.Collection( resultGetAll, e1 => Assert.Equal( 1, e1.Id ), e2 => Assert.Equal( 2, e2.Id ) );
    }
}
