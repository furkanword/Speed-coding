using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configGMedico: IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
    
        builder.ToTable("Medico");

        builder.Property(m => m.Med_numero_matricula_postal)
        .HasColumnName("med_nroMatriculaProfecional")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(m => m.Med_nombre_completo)
        .HasColumnName("med_nombreCompleto")
        .HasMaxLength(120)
        .IsRequired();

        builder.Property(m => m.Med_consultorio_id)
        .HasColumnName("med_consultorio")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(m => m.Med_especialidad_id)
        .HasColumnName("med_especialidad")
        .HasColumnType("INT")
        .IsRequired();

        builder.HasOne(m => m.Especialidad)
        .WithMany(e => e.Medicos)
        .HasForeignKey(m => m.Med_especialidad_id);

        builder.HasOne(m => m.Consultorio)
        .WithMany(e => e.Medicos)
        .HasForeignKey(m => m.Med_consultorio_id);



    }
}