namespace ExpressoPizza.Dominio
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool IsUsuarioAutenticado { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string senha, bool isUsuarioAutenticado)
        {
            Nome = nome;
            Senha = senha;
            IsUsuarioAutenticado = isUsuarioAutenticado;
        }
    }
}