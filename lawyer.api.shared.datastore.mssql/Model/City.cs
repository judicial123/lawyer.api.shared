using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.shared.datastore.mssql.Model.Common;

namespace lawyer.api.shared.datastore.mssql.Model;

[Table("Cities", Schema = "shared")]
public class CityEntity : EFEntity
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; }
}
