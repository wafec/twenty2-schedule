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

    public async IAsyncEnumerable<WorkerAvailabilityDto> GetWorkerAvailabilityList( long workerId )
    {
        throw new NotImplementedException();
    }

    public async IAsyncEnumerable<WorkRequestOption> GetWorkRequestOptions()
    {
        throw new NotImplementedException();
    }

    public async Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest )
    {
        throw new NotImplementedException();
    }
}

