using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Genero
{
    [Key]
    public int genero_Id { get; set; }
    public string ? genero_nombre { get; set; }
    public string ? genero_abreviatura { get; set; }
    public ICollection<Usuario> ? usuarios { get; set; }
    
}
