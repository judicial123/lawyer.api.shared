using MediatR;

namespace lawyer.api.leads.application.UseCases.SocialNetwork.Create;

public class CreateSocialNetworkCommand : IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
}
