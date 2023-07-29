namespace API.DTOs;
public class Tipo_documentoDto
{
    public int Id_DocType { get; set; }
    public string? DocType { get; set; }
    public string? Prefix { get; set; }        

    public List<UsuarioDto> Users { get; set; } = null!;

}