using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.SocialNetwork;

public class SocialNetworkQueryRepository : QueryRepository<domain.SocialNetwork, SocialNetworkEntity>, ISocialNetworkQueryRepository
{
    private readonly IMapper _mapper;

    public SocialNetworkQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
