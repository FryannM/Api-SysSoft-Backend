using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO").HasKey(x => x.Usr_I_CodigoUsuario);

            builder.Property(x => x.Usr_I_CodigoUsuario)
                .HasColumnName("Usr_I_CodigoUsuario");

            builder.Property(x => x.Usr_V_Nombre)
               .HasColumnName("Usr_V_Nombre");

            builder.Property(x => x.Usr_V_NombreUsuario)
               .HasColumnName("Usr_V_NombreUsuario");

            builder.Property(x => x.Usr_V_PassWord)
               .HasColumnName("Usr_V_PassWord");

            builder.Property(x => x.Usr_V_Email)
                .HasColumnName("Usr_V_Email");

            builder.Property(x => x.Pos_I_Codigo)
            .HasColumnName("Pos_I_Codigo");
            builder.HasOne(x => x.Cargo);

            builder.Property(x => x.Estado)
               .HasColumnName("Estado");
        }
    }
}

