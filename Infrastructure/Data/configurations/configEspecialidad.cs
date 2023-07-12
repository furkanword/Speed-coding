using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configEspecialidad : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
    
        builder.ToTable("Especialidad");

        builder.Property(e => e.Especialidad_Id)
        .HasColumnName("esp_id")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(e => e.Especialidad_Nombre)
        .HasColumnName("esp_nombre")
        .HasMaxLength(20)
        .IsRequired();

    }
}


