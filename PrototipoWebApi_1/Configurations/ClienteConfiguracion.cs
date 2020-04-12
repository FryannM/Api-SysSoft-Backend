using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes").
                HasKey(x => x.Cli_I_Codigo);

            builder.Property(x => x.Cli_I_Codigo)
                .HasColumnName("Cli_I_Codigo");

            builder.Property(x => x.Cli_V_Nombre_1)
            .HasColumnName("Cli_V_Nombre_1");

            builder.Property(x => x.Cli_V_Nombre_2)
            .HasColumnName("Cli_V_Nombre_2");


            builder.Property(x => x.Cli_V_Apellido_1)
            .HasColumnName("Cli_V_Apellido_1");

            builder.Property(x => x.Cli_V_Apellido_2)
           .HasColumnName("Cli_V_Apellido_2");

             builder.Property(x => x.Cli_V_CedulaRnc)
            .HasColumnName("Cli_V_CedulaRnc");

             builder.Property(x => x.Cli_V_email)
            .HasColumnName("Cli_V_email");

              builder.Property(x => x.Cli_V_Telefono)
             .HasColumnName("Cli_V_Telefono");

              builder.Property(x => x.Pro_I_Codigo)
             .HasColumnName("Pro_I_Codigo");

              builder.HasOne(x => x.Proyecto);

        }
    }
}

        
        
    



   