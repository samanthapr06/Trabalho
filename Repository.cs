namespace _;

public interface IUsuarioRepository
{
    void AdicionarUsuario(Usuario usuario);
    Usuario? PegarUsuario(string email);
}

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _dbContext;

    public UsuarioRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        _dbContext.Usuario.Add(usuario);
        _dbContext.SaveChanges();
    }

    public Usuario? PegarUsuario(string email) {
        var usuario = _dbContext.Usuario.SingleOrDefault(e => email == e.Email);
        return usuario;
    }
}