using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class ColaboradorConfigurations : IEntityTypeConfiguration<Colaborador>
    {
      

        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaboradors").
            HasKey( x => x.Col_I_Codigo);

            builder.Property(x => x.Col_I_Codigo)
                .HasColumnName("Col_I_Codigo");

            builder.Property(x => x.Col_V_Cedula)
               .HasColumnName("Col_V_Cedula");

            builder.Property(x => x.Col_V_Nombre_1)
                .HasColumnName("Col_V_Nombre_1");

            builder.Property(x => x.Col_V_Nombre_2)
               .HasColumnName("Col_V_Nombre_2");

            builder.Property(x => x.Col_V_Apellido_1)
                .HasColumnName("Col_V_Apellido_1");

            builder.Property(x => x.Col_V_Apellido_2)
               .HasColumnName("Col_V_Apellido_2");

            builder.Property(x => x.Col_C_Sexo)
                .HasColumnName("Col_C_Sexo");

            builder.Property(x => x.Col_D_Fecha_Nacimiento)
               .HasColumnName("Col_D_Fecha_Nacimiento");

            builder.Property(x => x.Dep_I_Codigo)
                .HasColumnName("Dep_I_Codigo");

            builder.Property(x => x.Pos_I_Codigo)
                .HasColumnName("Pos_I_Codigo");

            builder.Property(x => x.Col_B_Estado)
               .HasColumnName("Col_B_Estado");



        }
    }
}
