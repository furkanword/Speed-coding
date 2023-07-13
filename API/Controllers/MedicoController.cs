
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class MedicoController : BaseController
{
    private readonly  InventarioContext  _context;
    public MedicoController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Medico>>> Get()
    {
        var namevar = await _context.Medicos.ToListAsync();
        return Ok(namevar);
    }

    
}
