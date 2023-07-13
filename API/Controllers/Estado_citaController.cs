
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class Estado_citaController : BaseController
{
    private readonly  InventarioContext  _context;
    public Estado_citaController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Estado_cita>>> Get()
    {
        var namevar = await _context.Estado_Citas.ToListAsync();
        return Ok(namevar);
    }

    
}
