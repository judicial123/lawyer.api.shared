using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.Country;

public class CountryCommandRepository : CommandRepository<domain.Country, CountryEntity>, ICountryCommandRepository
{
    private readonly IMapper _mapper;

    public CountryCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
