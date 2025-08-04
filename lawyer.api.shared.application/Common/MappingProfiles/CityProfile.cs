using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.City.Create;
using lawyer.api.shared.application.UseCases.City.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<CityDto, City>().ReverseMap();
        CreateMap<CreateCityCommand, City>().ReverseMap();
        CreateMap<UpdateCityCommand, City>().ReverseMap();
    }
}
