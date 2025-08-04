using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.Country.Create;
using lawyer.api.shared.application.UseCases.Country.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<CountryDto, Country>().ReverseMap();
        CreateMap<CreateCountryCommand, Country>().ReverseMap();
        CreateMap<UpdateCountryCommand, Country>().ReverseMap();
    }
}
