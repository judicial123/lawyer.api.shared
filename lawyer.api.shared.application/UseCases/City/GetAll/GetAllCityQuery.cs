using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.City.GetAll;

public class GetAllCityQuery : IRequest<List<CityDto>>, IRequest<CityDto>
{
}
