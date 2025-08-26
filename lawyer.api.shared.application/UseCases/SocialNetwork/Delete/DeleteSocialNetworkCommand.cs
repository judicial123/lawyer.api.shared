using MediatR;

namespace lawyer.api.shared.application.UseCases.SocialNetwork.Delete;

public class DeleteSocialNetworkCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
