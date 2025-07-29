using System.Linq;

namespace exercicio4
{
    public class Usuario
    {
        public string Email { get; }
        public string Nome { get; }
        public string Senha { get; }

        public Usuario(string email, string nome)
        {
            this.Email = email;
            this.Nome = nome;
            this.Senha = Guid.NewGuid().ToString();
        }
    }
    public class Program
    {
        public static List<Usuario>? OrdenaUsuarios(List<Usuario> array)
        {
            var users = new List<Usuario>();

            try
            {
                if (array == null || array.Count < 1)
                    throw new Exception("A lista não pode ser nula ou vazia");

                var listaOrdenada = array.OrderBy(x => x.Nome).ToList();

                foreach (var item in listaOrdenada)
                {
                    if (users.Any(c => c.Nome == item.Nome))
                        throw new Exception($"Já existe usuário com o nome {item.Nome} cadastrado");

                    users.Add(new Usuario(item.Email, item.Nome));
                }

                listaOrdenada.ForEach(item => Console.WriteLine($"{item.Nome}\t{item.Email}"));

                return listaOrdenada;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return null;
            }
        }

        public static void Main(string[] args)
        {
            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"Ana Maria"}, Usuario{"João Carlos"}, Usuario{"João Marcelo"}, Usuario{"Pedro Almeida"} }

            OrdenaUsuarios(new List<Usuario> { }); // new List<Usuario> {}

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Carlos")}); // ERRO

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("joaozin@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Carlos S")}); // new List<Usuario> {Usuario{"Ana Maria"}, Usuario{"João Carlos"}, Usuario{"João Marcelo"}, Usuario{"Pedro Almeida"} }

            OrdenaUsuarios(null); // ERRO
        }
    }
}

