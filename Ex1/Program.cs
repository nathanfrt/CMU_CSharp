using Ex1;

namespace exercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var biblioteca = new Biblioteca();
            Console.WriteLine("\nPalavras terminadas em A");
            biblioteca.FiltraTerminadasEmA(new List<string> { "Pera", "Maçã", "Banana", "Uva", "Abacate" });

            Console.WriteLine("\nPalavras não terminadas em A");
            biblioteca.FiltraTerminadasEmA(new List<string> { "Caderno", "Corretivo", "Computador", "Lápis", "Marcador" });

            Console.WriteLine("\nPalavras terminadas em número ou caracteres especiais");
            biblioteca.FiltraTerminadasEmA(new List<string> { "Per$", "Maç4", "Banan@", "Uva.", "Uva", "Abacat!" });

            Console.WriteLine("\nParâmetro nulo");
            biblioteca.FiltraTerminadasEmA(new List<string>());
        }
    }
}

