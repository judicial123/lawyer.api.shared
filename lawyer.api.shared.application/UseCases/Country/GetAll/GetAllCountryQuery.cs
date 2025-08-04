using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.GetAll;

public class GetAllCountryQuery : IRequest<List<CountryDto>>, IRequest<CountryDto>
{
}
