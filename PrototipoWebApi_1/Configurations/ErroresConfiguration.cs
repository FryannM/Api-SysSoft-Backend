using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class ErroresConfiguration : IEntityTypeConfiguration<Errores>
    {
        public void Configure(EntityTypeBuilder<Errores> builder)
        {
            builder.ToTable("ERRORES").HasKey(x => x.Codigo);


            builder.Property(x => x.Codigo)
               .HasColumnName("Codigo");

            builder.Property(x => x.Mensaje)
               .HasColumnName("Mensaje");

            builder.Property(x => x.StackTrace)
               .HasColumnName("StackTrace");

            builder.Property(x => x.Source)
               .HasColumnName("Source");


            builder.Property(x => x.Usr_I_CodigoUsuario)
             .HasColumnName("Usr_I_CodigoUsuario");

          //  builder.HasOne(x => x.Usuario);


        }
    }
}
