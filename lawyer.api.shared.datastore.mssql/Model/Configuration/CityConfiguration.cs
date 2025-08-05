using lawyer.api.shared.datastore.mssql.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lawyer.api.shared.datastore.mssql.Model.Configuration;

public class CityConfiguration : IEntityTypeConfiguration<CityEntity>
{
    public void Configure(EntityTypeBuilder<CityEntity> builder)
    {
        builder.HasOne(c => c.Country)
            .WithMany(country => country.Cities)
            .HasForeignKey(c => c.IdCountry);
    }
}
