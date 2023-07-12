using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Especialidad
{
    [Key]
    public int Especialidad_Id { get; set; }
    public string ? Especialidad_Nombre { get; set; }

    public ICollection<Especialidad> ? Especialidades { get; set; }
    
    
}
