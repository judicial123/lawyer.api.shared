using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.Delete;

public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, Unit>
{
    private readonly ICountryCommandRepository _command;
    private readonly ICountryQueryRepository _query;

    public DeleteCountryCommandHandler(ICountryCommandRepository command, ICountryQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
