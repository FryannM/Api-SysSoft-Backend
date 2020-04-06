using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO")
                .HasKey(x => x.Codigo);


            builder.Property(x => x.Codigo)
                .HasColumnName("Usr_I_Usuario");

            builder.Property(x => x.Nombre)
               .HasColumnName("Usr_V_Nombre");

            builder.Property(x => x.NombreUsuario)
               .HasColumnName("Usr_V_NombreUsuario");

            builder.Property(x => x.Password)
               .HasColumnName("Usr_V_PassWord");

            builder.Property(x => x.Email)
                .HasColumnName("Usr_V_Email");

            builder.Property(x => x.Roles)
            .HasColumnName("Usr_I_Roles");


        }
    }
}

