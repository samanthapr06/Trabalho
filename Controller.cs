using Microsoft.AspNetCore.Mvc;

namespace _;

[ApiController] 
[Route("api/[controller]")]
public class UsuarioController : ControllerBase 
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet("{email}")]
    public IActionResult PegarUsuarioPeloEmail([FromRoute] string email) {
        var usuario = _usuarioService.PegarUsuarioPeloEmail(email);
        if (usuario == null) {
            return NotFound("Usuário não encontrado");
        }

        return Ok(usuario);
    }

    [HttpPost]
    public IActionResult CadastrarNovoUsuario([FromBody] Usuario usuario) 
    {
        _usuarioService.CadastrarNovoUsuario(usuario);
        return Ok("Usuário cadastrado com sucesso.");
    }
}
