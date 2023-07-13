
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ConsultorioController : BaseController
{
    private readonly  InventarioContext  _context;
    public ConsultorioController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Consultorio>>> Get()
    {
        var namevar = await _context.Consultorios.ToListAsync();
        return Ok(namevar);
    }

    
}
