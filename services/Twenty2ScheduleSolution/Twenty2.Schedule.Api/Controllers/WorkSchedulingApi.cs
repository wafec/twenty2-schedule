using Microsoft.AspNetCore.Mvc;
using Twenty2.Schedule.Api.Dao;
using Twenty2.Schedule.Shared.Api;
using Twenty2.Schedule.Shared.Dto;

namespace Twenty2.Schedule.Api.Controllers;

[ApiController]
[Route( "api/work-scheduling" )]
public class WorkSchedulingApi : IWorkSchedulingApi
{
    private readonly IWorkerAvailabilityDao workerAvailabilityDao;

    public WorkSchedulingApi(
        IWorkerAvailabilityDao workerAvailabilityDao )
    {
        this.workerAvailabilityDao = workerAvailabilityDao;
    }

    [HttpGet( "get-worker-availability-list" )]
    public Task<IEnumerable<WorkerAvailabilityDto>> GetWorkerAvailabilityList( 
        long workerId, DateTime startDate, DateTime endDate )
    {
        throw new NotImplementedException();
    }

    [HttpGet( "get-work-request-options" )]
    public Task<IEnumerable<WorkRequestOption>> GetWorkRequestOptions()
    {
        throw new NotImplementedException();
    }

    [HttpGet( "submit-work-request" )]
    public Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest )
    {
        throw new NotImplementedException();
    }
}

