using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configAcudientes : IEntityTypeConfiguration<Acudiente>
{

    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        builder.ToTable("Acudiente");

        builder.Property(a => a.Codigo)
        .HasColumnName("acu_codigo")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(a => a.Nombre_completo)
        .HasColumnName("acu_nombreCompleto")
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(a => a.Telefono)
        .HasColumnName("acu_telefono")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(a => a.Direccion)
        .HasColumnName("acu_direccion")
        .HasMaxLength(200);
        

    }
}
