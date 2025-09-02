using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.leads.datastore.mssql.Model.Common;

namespace lawyer.api.leads.datastore.mssql.Model;

[Table("SocialNetworks", Schema = "shared")]
public class SocialNetworkEntity : EFEntity
{
    public string Name { get; set; }
}
