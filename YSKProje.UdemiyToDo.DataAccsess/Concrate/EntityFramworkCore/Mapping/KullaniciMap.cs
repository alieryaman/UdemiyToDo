using CYSKProje.UdemiyToDo.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Mapping
{
 public   class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(I=>I.Id);

            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Soyadi).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Telefon).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();
            builder.HasMany(I => I.Calismaalar).WithOne(I => I.Kullanici).HasForeignKey(I =>I.KullaniciId);



        }
    }
}
