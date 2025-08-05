using System.Collections.Generic;
using lawyer.api.shared.domain.Common;

namespace lawyer.api.shared.domain;

public class Country : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public List<City> Cities { get; set; } = new();
}
