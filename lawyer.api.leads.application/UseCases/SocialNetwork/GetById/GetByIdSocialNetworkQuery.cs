using lawyer.api.leads.application.DTO;
using MediatR;

namespace lawyer.api.leads.application.UseCases.SocialNetwork.GetById;

public class GetByIdSocialNetworkQuery : IRequest<SocialNetworkDto>
{
    public GetByIdSocialNetworkQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
