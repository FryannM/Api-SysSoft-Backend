using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class DepartamentoConfigurations : IEntityTypeConfiguration<Departamento>
    {


        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamentos")
                 .HasKey(x => x.Dep_I_Codigo);

            builder.Property(x => x.Dep_I_Codigo)
                .HasColumnName("Dep_I_Codigo");

            builder.Property(x => x.Dep_V_Descripcion)
                    .HasColumnName("Dep_V_Descripcion");


            builder.Property(x => x.Nombre)
                   .HasColumnName("Nombre");

            builder.Property(x => x.Estado)
                   .HasColumnName("Estado");
        }
    }
}
