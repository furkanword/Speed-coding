 

using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UsuarioController : BaseController
{
    private readonly  InventarioContext  _context;
    public UsuarioController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Usuario>>> Get()
    {
        var namevar = await _context.Usuarios.ToListAsync();
        return Ok(namevar);
    }

    
}

    
