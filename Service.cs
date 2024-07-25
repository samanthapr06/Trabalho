namespace _;

public interface IUsuarioService
{
    void CadastrarNovoUsuario(Usuario usuario);
    Usuario? PegarUsuarioPeloEmail(string email);
}

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public void CadastrarNovoUsuario(Usuario usuario)
    {
        _usuarioRepository.AdicionarUsuario(usuario);
    }

    public Usuario? PegarUsuarioPeloEmail(string email) {
        var usuario = _usuarioRepository.PegarUsuario(email);
        return usuario;
    }
}
