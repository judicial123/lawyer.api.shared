using lawyer.api.leads.application.DTO;
using MediatR;

namespace lawyer.api.leads.application.UseCases.SocialNetwork.GetAll;

public class GetAllSocialNetworkQuery : IRequest<List<SocialNetworkDto>>, IRequest<SocialNetworkDto>
{
}
