using System.ComponentModel.DataAnnotations;
namespace core.Entities;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public string ? Segundo_nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Segundo_apellido { get; set; }
    public string? Telefono { get; set; }
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public ICollection<Cita> ? citas { get; set; }

    public int Tipo_documento_id { get; set; }
    public Tipo_documento ? Tipo_documento {get; set; }

    public int Genero_id { get; set; }
    public Genero ? Genero {get; set; }

    public int Acudiente_id { get; set; } 
    public Acudiente ? Acudiente {get; set; }

    

}
