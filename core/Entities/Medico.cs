using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Medico
{
    [Key]
    public int Med_numero_matricula_postal { get; set; }
    public string ? Med_nombre_completo { get; set; }
    public ICollection<Cita> ? citas { get; set; }

    public int Med_consultorio_id { get; set; }
    public Consultorio ? Consultorio { get; set; }

    public int Med_especialidad_id { get; set; }
    public Especialidad ? Especialidad { get; set; }

    
}
