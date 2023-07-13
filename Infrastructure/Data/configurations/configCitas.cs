using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configCitas : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
    
        builder.ToTable("Cita");

        builder.Property(x => x.cita_codigo)
        .HasColumnName("cit_codigo")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(x => x.cita_fecha)
        .HasColumnName("cit_fecha")
        .HasColumnType("DATE")
        .IsRequired();


        builder.Property(x => x.cita_estado_id)
        .HasColumnName("cit_estadoCita")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(x => x.cita_medico_id)
        .HasColumnName("cit_medico")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(x => x.cita_datos_Usuario_id)
        .HasColumnName("cit_datosUsuario")
        .HasColumnType("INT")
        .IsRequired();

        builder.HasOne(m => m.Estado_Cita)
        .WithMany(e => e.citas)
        .HasForeignKey(m => m.cita_estado_id);

        builder.HasOne(m => m.Usuario)
        .WithMany(e => e.citas)
        .HasForeignKey(m => m.cita_datos_Usuario_id);

        builder.HasOne(m => m.Medico)
        .WithMany(e => e.citas)
        .HasForeignKey(m => m.cita_medico_id);
    }
}
