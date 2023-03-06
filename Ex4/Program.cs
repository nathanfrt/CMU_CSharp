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
        public static List<Usuario> OrdenaUsuarios(List<Usuario> array)
        {
            // Coloque seu código aqui
            return null;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto(s) retornados!

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"Ana Maria"}, Usuario{"João Carlos"}, Usuario{"João Marcelo"}, Usuario{"Pedro Almeida"} }

            OrdenaUsuarios(new List<Usuario> {}); // new List<Usuario> {}

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Carlos")}); // ERRO

            OrdenaUsuarios(null); // ERRO
        }
    }
}

