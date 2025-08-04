using lawyer.api.shared.domain.Common;

namespace lawyer.api.shared.domain;

public class City : BaseEntity
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
