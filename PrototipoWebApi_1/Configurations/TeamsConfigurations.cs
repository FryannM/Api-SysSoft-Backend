using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class TeamsConfigurations : IEntityTypeConfiguration<Team>
    {
       
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team").HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo)
                .HasColumnName("Codigo");

            builder.Property(x => x.Descripcion)
                .HasColumnName("Descripcion");

            builder.Property(x => x.CantidadIntegrantes)
             .HasColumnName("CantidadIntegrantes");

            builder.Property(x => x.Estado)
             .HasColumnName("Estado");

            builder.Property(x => x.FechaCreacion)
             .HasColumnName("FechaCreacion");

            builder.Property(x => x.Proyectos)
             .HasColumnName("Proyectos");
        }
    }
}
