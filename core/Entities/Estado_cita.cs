using System.ComponentModel.DataAnnotations;
namespace core.Entities;

public class Estado_cita
{
    [Key]
    public int Estado_cita_Id { get; set; }
    public string ? Estado_cita_Nombre { get; set; }
    
    public ICollection<Cita> ? citas { get; set; }
    
}
