

using core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class Tipo_documentoController : BaseController
{
    private readonly  InventarioContext  _context;
    public Tipo_documentoController(InventarioContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Tipo_documento>>> Get()
    {
        var namevar = await _context.Tipo_Documentos.ToListAsync();
        return Ok(namevar);
    }

    
}
