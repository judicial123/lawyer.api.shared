using AutoMapper;
using lawyer.api.leads.application.DTO;
using lawyer.api.leads.application.UseCases.SocialNetwork.Create;
using lawyer.api.leads.application.UseCases.SocialNetwork.Update;
using lawyer.api.leads.domain;

namespace lawyer.api.leads.application.Common.MappingProfiles;

public class SocialNetworkProfile : Profile
{
    public SocialNetworkProfile()
    {
        CreateMap<SocialNetworkDto, SocialNetwork>().ReverseMap();
        CreateMap<CreateSocialNetworkCommand, SocialNetwork>().ReverseMap();
        CreateMap<UpdateSocialNetworkCommand, SocialNetwork>().ReverseMap();
    }
}
