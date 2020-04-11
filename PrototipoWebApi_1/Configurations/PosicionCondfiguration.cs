using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class PosicionCondfiguration : IEntityTypeConfiguration<Posicion>
    {
        public void Configure(EntityTypeBuilder<Posicion> builder)
        {
            builder.ToTable("Posicion")
                .HasKey(x => x.Pos_I_Codigo);

            builder.Property(x => x.Pos_I_Codigo)
                .HasColumnName("Pos_I_Codigo");

            builder.Property(x => x.Pos_V_Descripcion)
               .HasColumnName("Pos_V_Descripcion");

            builder.Property(x => x.Estado)
              .HasColumnName("Estado");

            builder.Property(x => x.Sueldo)
              .HasColumnName("Sueldo");

            builder.Property(x => x.Perfil)
              .HasColumnName("Perfil");
        }
    }
}   
