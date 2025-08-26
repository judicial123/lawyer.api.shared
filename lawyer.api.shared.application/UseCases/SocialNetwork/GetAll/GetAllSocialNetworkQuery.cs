using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.SocialNetwork.GetAll;

public class GetAllSocialNetworkQuery : IRequest<List<SocialNetworkDto>>, IRequest<SocialNetworkDto>
{
}
