using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configGenero: IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
    
        builder.ToTable("Genero");

        builder.Property(g => g.genero_Id)
        .HasColumnName("gen_id")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(g => g.genero_nombre)
        .HasColumnName("gen_nombre")
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(g => g.genero_abreviatura)
        .HasColumnName("gen_abreviatura")
        .HasMaxLength(20)
        .IsRequired();

    }
}