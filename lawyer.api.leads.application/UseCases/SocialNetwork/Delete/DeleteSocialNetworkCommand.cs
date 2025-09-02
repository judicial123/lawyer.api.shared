using MediatR;

namespace lawyer.api.leads.application.UseCases.SocialNetwork.Delete;

public class DeleteSocialNetworkCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
