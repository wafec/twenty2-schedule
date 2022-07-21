namespace Twenty2.Schedule.Shared.Api;

using Twenty2.Schedule.Shared.Dto;

public interface IWorkSchedulingApi
{
    Task<IEnumerable<WorkRequestOption>> GetWorkRequestOptions();

    Task<IEnumerable<WorkerAvailabilityDto>> GetWorkerAvailabilityList( long workerId );

    Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest );
}

