
namespace Infrastructure.UnitOfWork;

public class UnitOfWork: IUnitteOfWork
{

    public UnitOfWork(InventarioContext _context){
        context = _context;
    }
    public IAcudiente Acudientes => throw new  AcudienteRepository(context);
    public ICita Cita => throw new NotImplementedException();
    public IConsultorio Consultorio => throw new NotImplementedException();
    public IEspecialidad Especialidad => throw new NotImplementedException();
    public IEstado_cita Estado_cita => throw new NotImplementedException();
    public IGenero Genero => throw new NotImplementedException();
    public IMedico Medico => throw new NotImplementedException();
    public ITipo_documento Tipo_Documento => throw new NotImplementedException();
    public IUsuario Usuario => throw new NotImplementedException();

    public UnitOfWork(InventarioContext _context){
        context = _context;
    }


    public IAcudientes Acudientes{
        get{
            if(_Acudientes == null){
                _Acudientes = new  AcudienteRepository(context);
            }
            return _Acudientes;
        }
    }

    public ICita Citas{
        get{
            if(_Citas == null){
                _Citas = new  CitaRepository(context);
            }
            return _Citas;
        }
    }

    public IConsultorio Consultorios{
        get{
            if(_Consultorios == null){
                _Consultorios = new  ConsultorioRepository(context);
            }
            return _Consultorios;
        }
    }

    public IEspecialidad Especialidades{
        get{
            if(_Especialidades == null){
                _Especialidades = new  EspecialidadRepository(context);
            }
            return _Especialidades;
        }
    }

    public IEstado_cita Estado_Citas{
        get{
            if(_Estado_Citas  == null){
                _Estado_Citas  = new  Estado_citaRepository(context);
            }
            return _Estado_Citas ;
        }
    }

    public IGenero Generos{
        get{
            if(_Generos  == null){
                _Generos  = new  GeneroRepository(context);
            }
            return _Generos;
        }
    }

     public IMedico Medicos{
        get{
            if(_Medicos  == null){
                _Medicos  = new  CitaRepository(context);
            }
            return _Medicos ;
        }
    }
    
     public ITipo_Documento Tipo_Documentos{
        get{
            if(_Tipo_Documentos  == null){
                _Tipo_Documentos  = new  Tipo_Repository(context);
            }
            return _Tipo_Documentos ;
        }
    }

     public IUsuario Usuarios{
        get{
            if(_Usuarios  == null){
                _Usuarios  = new  UsuarioRepository(context);
            }
            return _Usuarios ;
        }
    }
    



    public int Save(){
        throw new NotImplementedException();
    }

}
