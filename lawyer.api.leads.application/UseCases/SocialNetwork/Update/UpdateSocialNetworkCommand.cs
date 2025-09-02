using MediatR;

namespace lawyer.api.leads.application.UseCases.SocialNetwork.Update;

public class UpdateSocialNetworkCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
