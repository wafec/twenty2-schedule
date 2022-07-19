namespace Twenty2.Schedule.Shared.Api;

using Twenty2.Schedule.Shared.Dto;

public interface IWorkSchedulingApi
{
    IAsyncEnumerable<WorkRequestOption> GetWorkRequestOptions();

    IAsyncEnumerable<WorkerAvailabilityDto> GetWorkerAvailabilityList( long workerId );

    Task<UserAppointmentDto> SubmitWorkRequest( WorkRequestDto workRequest );
}

