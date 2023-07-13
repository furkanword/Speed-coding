using System.ComponentModel.DataAnnotations;

namespace core.Entities;

public class Cita
{
    [Key]
    public int cita_codigo { get;set; }

    public DateTime cita_fecha { get;set; }

    public int cita_estado_id { get;set; }
    public Estado_cita ? Estado_Cita { get;set; }

    public int cita_medico_id { get;set; }
    public Medico ? Medico { get;set; }

    public int cita_datos_Usuario_id { get;set; }
    public virtual Usuario ? Usuario { get; set; }
    
}
