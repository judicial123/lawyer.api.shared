using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.SocialNetwork.Create;
using lawyer.api.shared.application.UseCases.SocialNetwork.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class SocialNetworkProfile : Profile
{
    public SocialNetworkProfile()
    {
        CreateMap<SocialNetworkDto, SocialNetwork>().ReverseMap();
        CreateMap<CreateSocialNetworkCommand, SocialNetwork>().ReverseMap();
        CreateMap<UpdateSocialNetworkCommand, SocialNetwork>().ReverseMap();
    }
}
