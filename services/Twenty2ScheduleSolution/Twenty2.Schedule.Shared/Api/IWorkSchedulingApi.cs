namespace Twenty2.Schedule.Shared.Api;

using Twenty2.Schedule.Shared.Dto;

public interface IWorkSchedulingApi
{
    IEnumerable<WorkRequestOption> GetWorkRequestOptions();

    IEnumerable<WorkerAvailabilityDto> GetWorkerAvailabilityList( long workerId );

    UserAppointmentDto SubmitWorkRequest( WorkRequestDto workRequest );
}

