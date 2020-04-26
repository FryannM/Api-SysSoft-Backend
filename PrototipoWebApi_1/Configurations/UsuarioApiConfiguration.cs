using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class UsuarioApiConfiguration : IEntityTypeConfiguration<UsuarioApi>
    {
        public void Configure(EntityTypeBuilder<UsuarioApi> builder)
        {
            builder.ToTable("UsuarioApi").HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("Id");

            builder.Property(x => x.UserName)
              .HasColumnName("userName");

            builder.Property(x => x.Name)
            .HasColumnName("Name");

            builder.Property(x => x.Password)
              .HasColumnName("password");

            builder.Property(x => x.Email)
              .HasColumnName("Email");

            builder.Property(x => x.AccessToken)
              .HasColumnName("accessToken");

            builder.Property(x => x.Estado)
              .HasColumnName("Estado");

            builder.Property(x => x.Pos_I_Codigo)
          .HasColumnName("Pos_I_Codigo");
            builder.HasOne(x => x.Cargo);







        }
    }
}
