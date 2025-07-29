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
        public static List<Usuario>? IdentificaDuplicados(List<Usuario>? array)
        {
            var users = new List<Usuario>();

            try
            {
                if (array == null || array.Count < 1)
                    throw new Exception("A lista não pode ser nula ou vazia");

                var listaDuplicados = new List<Usuario>();

                foreach (var item in array)
                {
                    if (users.Any(c => c.Email == item.Email))
                        listaDuplicados.Add(item);

                    users.Add(item);
                }

                if (listaDuplicados == null || listaDuplicados.Count < 1)
                    throw new Exception($"A lista não contém E-mails duplicados");

                listaDuplicados.ForEach(item => Console.WriteLine($"{item.Nome}\t{item.Email}"));

                return listaDuplicados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return null;
            }
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto(s) retornados!

            IdentificaDuplicados(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {}

            IdentificaDuplicados(new List<Usuario> {
                new Usuario("joaozin@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"João Carlos"}, Usuario{"João Marcelo"}}

            IdentificaDuplicados(new List<Usuario> { }); // new List<Usuario> {}

            IdentificaDuplicados(null); // ERRO
        }
    }
}

