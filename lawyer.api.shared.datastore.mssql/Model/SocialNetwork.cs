using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.shared.datastore.mssql.Model.Common;

namespace lawyer.api.shared.datastore.mssql.Model;

[Table("SocialNetworks", Schema = "shared")]
public class SocialNetworkEntity : EFEntity
{
    public string Name { get; set; }
}
