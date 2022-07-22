using AutoMapper;
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
    private readonly IMapper mapper;

    public WorkSchedulingApi(
        IWorkerAvailabilityDao workerAvailabilityDao,
        IMapper mapper )
    {
        this.workerAvailabilityDao = workerAvailabilityDao;
        this.mapper = mapper;
    }

    [HttpGet( "get-worker-availability-list" )]
    public async Task<IEnumerable<WorkerAvailabilityDto>> GetWorkerAvailabilities( 
        long workerId, DateTime startDate, DateTime endDate )
    {
        var workerAvailabilities = ( await workerAvailabilityDao.GetAll() )
            .Where( x => x.WorkerId == workerId
                && ( ( startDate >= x.StartDate && startDate < x.EndDate )
                        || ( endDate >= x.StartDate && endDate < x.EndDate )
                        || ( startDate <= x.StartDate && endDate > x.EndDate ) ) )
            .ToList();
        return workerAvailabilities.Select( x => mapper.Map<WorkerAvailabilityDto>( x ) ).AsEnumerable();
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

