using AutoMapper;
using Moq;
using Twenty2.Schedule.Api.Controllers;
using Twenty2.Schedule.Api.Dao;
using Twenty2.Schedule.Api.Entities;
using Twenty2.Schedule.Shared.Dto;
using Xunit;

namespace Twenty2.Schedule.Tests.Api.Controllers;

public class WorkSchedulingApiTest
{
    private WorkSchedulingApi sut;

    private Mock<IMapper> mapperMock;
    private Mock<IWorkerAvailabilityDao> workerAvailabilityDaoMock;

    public WorkSchedulingApiTest()
    {
        mapperMock = new Mock<IMapper>();
        workerAvailabilityDaoMock = new Mock<IWorkerAvailabilityDao>();
        sut = new WorkSchedulingApi( workerAvailabilityDaoMock.Object, mapperMock.Object );
    }

    [Fact]
    public async void GetWorkerAvailabilities_WhenTheWorkerExistsAndHasSchedule_ShoudReturnAvailabilities()
    {
        var before = new WorkerAvailability() { Id = 1, StartDate = new DateTime( 2022, 01, 01, 10, 00, 00 ), EndDate = new DateTime( 2022, 01, 01, 12, 00, 00 ), WorkerId = 2 };
        var item1 = new WorkerAvailability() { Id = 2, StartDate = new DateTime( 2022, 01, 01, 12, 00, 00 ), EndDate = new DateTime( 2022, 01, 01, 14, 00, 00 ), WorkerId = 2 };
        var item2 = new WorkerAvailability() { Id = 3, StartDate = new DateTime( 2022, 01, 01, 14, 30, 00 ), EndDate = new DateTime( 2022, 01, 01, 16, 00, 00 ), WorkerId = 2 };
        var after = new WorkerAvailability() { Id = 4, StartDate = new DateTime( 2022, 01, 01, 16, 00, 00 ), EndDate = new DateTime( 2022, 01, 01, 18, 00, 00 ), WorkerId = 2 };
        var list = new List<WorkerAvailability> { before, item1, item2, after };
       
        workerAvailabilityDaoMock.Setup( x => x.GetAll() )
            .ReturnsAsync( list );

        var result = await sut.GetWorkerAvailabilities( 2, new DateTime( 2022, 01, 01, 12, 00, 00 ), new DateTime( 2022, 01, 01, 16, 00, 00) );

        mapperMock.Verify( x => x.Map<WorkerAvailabilityDto>( It.IsAny<object>() ), Times.AtLeastOnce );
    }
}

