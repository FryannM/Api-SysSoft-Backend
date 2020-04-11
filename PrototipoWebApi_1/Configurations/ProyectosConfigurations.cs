using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class ProyectosConfigurations : IEntityTypeConfiguration<Proyecto>
    {
       
        public void Configure(EntityTypeBuilder<Proyecto> builder)
        {
            builder.ToTable("Proyectos")
              .HasKey(x => x.Pro_I_Codigo);

            builder.Property(x => x.Pro_I_Codigo)
                .HasColumnName("Pro_I_Codigo");

            builder.Property(x => x.Pro_V_Descripcion)
                .HasColumnName("Pro_V_Descripcion");

            builder.Property(x => x.Fecha_Inicio)
               .HasColumnName("Fecha_Inicio");

            builder.Property(x => x.Fecha_Fin)
               .HasColumnName("Fecha_Fin");

            builder.Property(x => x.Estado)
            .HasColumnName("Estado");
        }
    }
}
