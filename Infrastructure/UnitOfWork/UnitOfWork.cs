using core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork,IDisposable
{    
    private readonly InventarioContext _context;
    private AcudienteRepository? _acudiente;
    private CitaRepository? _cita;
    private ConsultorioRepository? _consultorio;
    private EspecialidadRepository? _especialidad;
    private Estado_citaRepository? _estado;
    private GeneroRepository? _genero;
    private MedicoRepository? _medico;
    private Tipo_documentoRepository? _tipoDocumento;
    private UsuarioRepository? _usuario;

    public UnitOfWork(InventarioContext context)=>_context = context;

    public ICitas<Acudiente, int> Acudientes
    {
        get{
            if (_acudiente is not null)
            {
                return (ICitas<Acudiente, int>)_acudiente;
            }
            return (ICitas<Acudiente, int>)(_acudiente = new AcudienteRepository(_context));
        }
    }

    public ICitas<Cita, int> Citas
    {
        get{
            if (_cita is not null)
            {
                return _cita;
            }
            return _cita = new CitaRepository(_context);
        }
    }

    public ICitas<Consultorio, int> Consultorios
    {
        get{
            if (_consultorio is not null)
            {
                return (ICitas<Consultorio, int>)_consultorio;
            }
            return (ICitas<Consultorio, int>)(_consultorio = new ConsultorioRepository(_context));
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public ICitas<Especialidad, int> Especialidades
    {
        get{
            if (_especialidad is not null)
            {
                return (ICitas<Especialidad, int>)_especialidad;
            }
            return (ICitas<Especialidad, int>)(_especialidad = new EspecialidadRepository(_context));
        }
    }

    public ICitas<Estado_cita, int> Estados
    {
        get{
            if (_estado is not null)
            {
                return (ICitas<Estado_cita, int>)_estado;
            }
            return (ICitas<Estado_cita, int>)(_estado = new Estado_citaRepository(_context));
        }
    }

    public ICitas<Genero, int> Generos
    {
        get{
            if (_genero is not null)
            {
                return (ICitas<Genero, int>)_genero;
            }
            return (ICitas<Genero, int>)(_genero = new GeneroRepository(_context));
        }
    }

    public ICitas<Medico, int> Medicos
    {
        get{
            if (_medico is not null)
            {
                return (ICitas<Medico, int>)_medico;
            }
            return (ICitas<Medico, int>)(_medico = new MedicoRepository(_context));
        }
    }

    public async Task<int> SaveAsync(){
        return await _context.SaveChangesAsync();
    }

    public ICitas<Tipo_documento, int> TipoDocumentos
    {
        get{
            if (_tipoDocumento is not null)
            {
                return (ICitas<Tipo_documento, int>)_tipoDocumento;
            }
            return (ICitas<Tipo_documento, int>)(_tipoDocumento = new Tipo_documentoRepository(_context));
        }
    }

    public ICitas<Usuario, int> Usuarios
    {
        get{
            if (_usuario is not null)
            {
                return (ICitas<Usuario, int>)_usuario;
            }
            return (ICitas<Usuario, int>)(_usuario = new UsuarioRepository(_context));
        }
    }
}