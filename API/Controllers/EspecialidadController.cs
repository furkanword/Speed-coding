
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class EspecialidadController : BaseController
{
    private readonly  InventarioContext  _context;
    public EspecialidadController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Especialidad>>> Get()
    {
        var namevar = await _context.Especialidades.ToListAsync();
        return Ok(namevar);
    }

    
}
