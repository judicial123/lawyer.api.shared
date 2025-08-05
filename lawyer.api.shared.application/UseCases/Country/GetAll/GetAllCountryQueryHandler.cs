using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.GetAll;

public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, List<CountryQueryDto>>
{
    private readonly ICountryQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllCountryQueryHandler(
        IMapper mapper,
        ICountryQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<CountryQueryDto>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync("Cities");
        return _mapper.Map<List<CountryQueryDto>>(entities);
    }
}
