using System.Collections.Generic;

namespace lawyer.api.shared.application.DTO;

public class CountryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<CityDto> Cities { get; set; } = new();
}
