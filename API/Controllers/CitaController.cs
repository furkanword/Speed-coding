
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class CitaController : BaseController
{
    private readonly  InventarioContext  _context;
    public CitaController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Cita>>> Get()
    {
        var namevar = await _context.Citas.ToListAsync();
        return Ok(namevar);
    }

    
}

    