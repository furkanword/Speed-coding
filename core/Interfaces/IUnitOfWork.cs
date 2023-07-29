using core.Entities;
using core.Interfaces;

namespace Core.Interfaces;
public interface IUnitOfWork
{
    ICitas<Acudiente,int> Acudientes{get;}
    ICitas<Cita,int> Citas{get;}
    ICitas<Consultorio,int> Consultorios{get;}
    ICitas<Especialidad,int> Especialidades{get;}
    ICitas<Estado_cita,int> Estados{get;}
    ICitas<Genero,int> Generos{get;}
    ICitas<Medico,int> Medicos{get;}
    ICitas<Tipo_documento,int> TipoDocumentos{get;}
    ICitas<Usuario,int> Usuarios{get;}
    
    Task<int> SaveAsync();
}