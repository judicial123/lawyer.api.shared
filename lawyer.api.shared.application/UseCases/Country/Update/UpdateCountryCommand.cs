using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.Update;

public class UpdateCountryCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
