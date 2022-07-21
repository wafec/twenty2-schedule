namespace Twenty2.Schedule.Api.Controllers;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Twenty2.Schedule.Api.Repositories;
using Twenty2.Schedule.Shared.Api;
using Twenty2.Schedule.Shared.Dto;

[ApiController]
[Route( "api/work-scheduling" )]
public class WorkSchedulingApi : IWorkSchedulingApi
{
    private readonly IWorkerAvailabilityRepository workerAvailabilityRepository;

    public WorkSchedulingApi(
        IWorkerAvailabilityRepository workerAvailabilityRepository )
    {
        this.workerAvailabilityRepository = workerAvailabilityRepository;
    }

    [HttpGet( "get-worker-availability-list" )]
    public Task<IEnumerable<WorkerAvailabilityDto>> GetWorkerAvailabilityList( long workerId )
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

