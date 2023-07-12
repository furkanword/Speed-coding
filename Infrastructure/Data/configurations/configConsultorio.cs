using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configConsultorio : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
    
        builder.ToTable("Consultorio");

        builder.Property(c => c.Consultorio_Id)
        .HasColumnName("cons_codigo")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(c => c.Consultorio_Nombre)
        .HasColumnName("const_nombre")
        .HasMaxLength(50)
        .IsRequired();

    }
}
