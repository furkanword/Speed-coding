using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Consultorio
{
    [Key]
    public int Consultorio_Id { get; set; }
    public string ? Consultorio_Nombre { get; set; }
    public ICollection<Medico> ? Medicos { get; set; }
    
}
