using AutoMapper;
using Twenty2.Schedule.Api.Entities;
using Twenty2.Schedule.Shared.Dto;

namespace Twenty2.Schedule.Api.Mapper;

public class WorkerAvailabilityProfile : Profile
{
    public WorkerAvailabilityProfile()
    {
        CreateMap<WorkerAvailability, WorkerAvailabilityDto>();
    }
}

