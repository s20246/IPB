using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Entities.Configurations
{
    public class TelephoneEfConfiguration : IEntityTypeConfiguration<Telephone>
    {
        public void Configure(EntityTypeBuilder<Telephone> builder)
        {
            builder.HasKey(e => e.IdTelephone).HasName("Telephone_pk");
            builder.Property(e => e.IdTelephone).UseIdentityColumn();
            builder.Property(e => e.Brand).IsRequired().HasMaxLength(60);
            builder.Property(e => e.Model).IsRequired().HasMaxLength(60);
            builder.Property(e => e.ReleaseDate);
            builder.HasData(new Telephone { IdTelephone = 1, Brand = "Nokia", Model = "nokia 50", ReleaseDate = new DateTime(2020, 2, 4) },
                        new Telephone { IdTelephone = 2, Brand = "Apple", Model = "iPhone X", ReleaseDate = new DateTime(2022, 4, 9) },
                        new Telephone { IdTelephone = 3, Brand = "Samsung", Model = "Galaxy s9", ReleaseDate = new DateTime(2019, 3, 18) });
            builder.ToTable("Telephone");

        }
    }
}
