using Twenty2.Schedule.Shared.Dto;

namespace Twenty2.Schedule.Shared.Api;

public interface IWorkSchedulingApi
{
    Task<IEnumerable<WorkRequestOption>> GetWorkRequestOptions();

    Task<IEnumerable<WorkerAvailabilityDto>> GetWorkerAvailabilityList( 
        long workerId, DateTime startDate, DateTime endDate );

    Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest );
}

