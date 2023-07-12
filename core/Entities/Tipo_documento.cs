using System.ComponentModel.DataAnnotations;
namespace core.Entities;

public class Tipo_documento
{
    [Key]
    public int id_tipo_documento { get; set; }
    public string ? tipo_documento_nombre { get; set; }
    public string ? tipo_documento_abreviatura { get; set; }
    public ICollection<Usuario> ? usuarios { get; set; }

    
}
