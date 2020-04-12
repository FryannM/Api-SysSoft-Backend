using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class TareasConfiguration  :IEntityTypeConfiguration<Tareas>
    {

        public void Configure(EntityTypeBuilder<Tareas> builder)
        {
            builder.ToTable("Tareas")
               .HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo)
               .HasColumnName("Codigo");

            builder.Property(x => x.Titulo)
               .HasColumnName("Titulo");

            builder.Property(x => x.Usuario);

            builder.HasOne(x => x.Proyecto);

            builder.HasOne(x => x.Usuario);
              

            builder.Property(x => x.Usr_I_CodigoUsuario)
             .HasColumnName("Usr_I_CodigoUsuario");

            builder.Property(x => x.FechaCreacion)
               .HasColumnName("FechaCreacion");

            builder.Property(x => x.Pro_I_Codigo)
               .HasColumnName("Pro_I_Codigo");

            builder.Property(x => x.Estado)
                .HasColumnName("Estado");

            builder.Property(x => x.Comentario)
               .HasColumnName("Comentario");
        }
    }
}
