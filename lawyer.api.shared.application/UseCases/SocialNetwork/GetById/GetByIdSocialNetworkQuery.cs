using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.SocialNetwork.GetById;

public class GetByIdSocialNetworkQuery : IRequest<SocialNetworkDto>
{
    public GetByIdSocialNetworkQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
