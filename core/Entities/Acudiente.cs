using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Acudiente
{
    [Key]
    public int Codigo { get; set; }
    public string ? Nombre_completo { get; set; }
    public string ? Telefono { get; set; }
    public string ? Direccion { get; set; }
    public ICollection<Usuario> ? usuarios { get; set; }
    
}
