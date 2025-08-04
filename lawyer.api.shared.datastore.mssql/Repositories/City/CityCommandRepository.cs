using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.City;

public class CityCommandRepository : CommandRepository<domain.City, CityEntity>, ICityCommandRepository
{
    private readonly IMapper _mapper;

    public CityCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
