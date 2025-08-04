using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.Create;

public class CreateCountryCommand : IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
}
