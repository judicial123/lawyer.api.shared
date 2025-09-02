using AutoMapper;
using lawyer.api.leads.application.Contracts.Interfaces.Persistence.SocialNetwork;
using lawyer.api.leads.datastore.mssql.DatabaseContext;
using lawyer.api.leads.datastore.mssql.Model;
using lawyer.api.leads.datastore.mssql.Repositories.Common;

namespace lawyer.api.leads.datastore.mssql.Repositories.SocialNetwork;

public class SocialNetworkCommandRepository : CommandRepository<domain.SocialNetwork, SocialNetworkEntity>, ISocialNetworkCommandRepository
{
    private readonly IMapper _mapper;

    public SocialNetworkCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
