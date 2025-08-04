using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Country;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Country.Create;

public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, Guid>
{
    private readonly ICountryCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateCountryCommandHandler(
        ICountryCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.Country>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
