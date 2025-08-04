using MediatR;

namespace lawyer.api.shared.application.UseCases.City.Create;

public class CreateCityCommand : IRequest<Guid>
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
