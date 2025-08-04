using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.City;
using MediatR;

namespace lawyer.api.shared.application.UseCases.City.Create;

public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, Guid>
{
    private readonly ICityCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateCityCommandHandler(
        ICityCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.City>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
