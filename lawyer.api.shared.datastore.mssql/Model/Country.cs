using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.shared.datastore.mssql.Model.Common;

namespace lawyer.api.shared.datastore.mssql.Model;

[Table("Countries", Schema = "shared")]
public class CountryEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Name { get; set; }
}
