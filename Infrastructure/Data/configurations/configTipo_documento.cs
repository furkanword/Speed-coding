using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configTipo_documento: IEntityTypeConfiguration<Tipo_documento>
{
    public void Configure(EntityTypeBuilder<Tipo_documento> builder)
    {
    
        builder.ToTable("Tipo_documento");

        builder.Property(t => t.id_tipo_documento)
        .HasColumnName("tipdoc_id")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(t => t.tipo_documento_nombre)
        .HasColumnName("tipdoc_nombre")
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(t => t.tipo_documento_abreviatura)
        .HasColumnName("tipdoc_abreviatura")
        .HasMaxLength(20)
        .IsRequired();


    }
}