using ExpressoPizza.Dominio;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class UsuarioRepositorio
    {
        public Usuario ObterUsuario(string nome, string senha)
        {
            if (nome == "leo" && senha == "123")
            {
                return new Usuario(nome, senha, true);
            }
            return new Usuario(nome, senha, false);
        }
    }
}