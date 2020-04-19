using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Configurations
{
    public class TeamColaboradoresConfigurations : IEntityTypeConfiguration<TeamColaboradores>
    {
        public void Configure(EntityTypeBuilder<TeamColaboradores> builder)
        {
            builder.ToTable("TeamColaboradores")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Codigo)
               .HasColumnName("Codigo");

            builder.Property(x => x.Col_I_Codigo)
                .HasColumnName("Col_I_Codigo");

            builder.Property(x => x.Fecha)
                .HasColumnName("Fecha");

            builder.Property(x => x.Estado)
               .HasColumnName("Estado");

            builder.HasOne(x => x.Colaborador);
            builder.HasOne(x => x.Team);
        }
    }
}
