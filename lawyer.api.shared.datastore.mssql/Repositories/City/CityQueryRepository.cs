using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.City;

public class CityQueryRepository : QueryRepository<domain.City, CityEntity>, ICityQueryRepository
{
    private readonly IMapper _mapper;

    public CityQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
