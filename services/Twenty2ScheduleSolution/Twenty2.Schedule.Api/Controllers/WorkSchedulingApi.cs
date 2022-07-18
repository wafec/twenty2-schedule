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

    public IEnumerable<WorkerAvailabilityDto> GetWorkerAvailabilityList( long workerId )
    {
        throw new NotImplementedException();
    }

    public IEnumerable<WorkRequestOption> GetWorkRequestOptions()
    {
        throw new NotImplementedException();
    }

    public UserAppointmentDto SubmitWorkRequest( WorkRequestDto workRequest )
    {
        throw new NotImplementedException();
    }
}

