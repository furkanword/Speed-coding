
using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class GeneroController : BaseController
{
    private readonly  InventarioContext  _context;
    public GeneroController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Genero>>> Get()
    {
        var namevar = await _context.Generos.ToListAsync();
        return Ok(namevar);
    }

    
}
