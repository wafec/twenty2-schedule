namespace Twenty2.Schedule.Api.Controllers;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Twenty2.Schedule.Shared.Api;
using Twenty2.Schedule.Shared.Dto;

[ApiController]
[Route( "work-scheduling" )]
public class WorkSchedulingApi : IWorkSchedulingApi
{
    public WorkSchedulingApi()
    {
        
    }

    [HttpGet( "get-worker-availability-list" )]
    public IAsyncEnumerable<WorkerAvailabilityDto> GetWorkerAvailabilityList( long workerId )
    {
        throw new NotImplementedException();
    }

    [HttpGet( "get-work-request-options" )]
    public IAsyncEnumerable<WorkRequestOption> GetWorkRequestOptions()
    {
        throw new NotImplementedException();
    }

    [HttpGet( "submit-work-request" )]
    public Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest )
    {
        throw new NotImplementedException();
    }
}

