using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configEstado_cita : IEntityTypeConfiguration<Estado_cita>
{
    public void Configure(EntityTypeBuilder<Estado_cita> builder)
    {
    
        builder.ToTable("Estado_cita");

        builder.Property(b => b.Estado_cita_Id)
        .HasColumnName("estcita_id")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(b => b.Estado_cita_Nombre)
        .HasColumnName("estcita_nombre")
        .HasMaxLength(20)
        .IsRequired();

    }
}