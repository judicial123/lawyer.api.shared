using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.domain;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.GetAll;

public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, List<CountryDto>>
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

    public async Task<List<CountryDto>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync(nameof(Country.Cities));
        return _mapper.Map<List<CountryDto>>(entities);
    }
}
