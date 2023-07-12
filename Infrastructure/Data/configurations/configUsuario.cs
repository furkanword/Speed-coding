using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configUsuario: IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
    
        builder.ToTable("Usuario");

        builder.Property(u => u.Id)
        .HasColumnName("usu_id")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(u => u.Nombre)
        .HasColumnName("usu_nombre")
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(u => u.Segundo_nombre)
        .HasColumnName("usu_segundo_nombre")
        .HasMaxLength(45);

        builder.Property(u => u.Apellido)
        .HasColumnName("usu_primer_apellido_usuar")
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(u => u.Segundo_apellido)
        .HasColumnName("usu_segundo_apellido_usuar")
        .HasMaxLength(50);

        builder.Property(u => u.Telefono)
        .HasColumnName("usu_telefono")
        .HasMaxLength(50)
        .IsRequired();
        
        builder.Property(u => u.Direccion)
        .HasColumnName("usu_direccion")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(u => u.Email)
        .HasColumnName("usu_e-mail")
        .HasMaxLength(100);


        builder.Property(u => u.Tipo_documento_id)
        .HasColumnName("usu_tipodoc")
        .HasColumnType("INT")
        .IsRequired();


        builder.Property(u => u.Genero_id)
        .HasColumnName("usu_genero")
        .HasColumnType("INT")
        .IsRequired();

        builder.Property(u => u.Acudiente_id)
        .HasColumnName("usu_acudiente")
        .HasColumnType("INT")
        .IsRequired();

    }
}