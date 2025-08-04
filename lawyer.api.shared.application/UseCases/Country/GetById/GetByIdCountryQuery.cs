using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.GetById;

public class GetByIdCountryQuery : IRequest<CountryDto>
{
    public GetByIdCountryQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
