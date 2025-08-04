using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;

public interface ICountryCommandRepository : ICommandRepository<domain.Country>
{
}
