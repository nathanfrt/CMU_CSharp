using System.Text.RegularExpressions;

namespace exercicio2
{
    public class Program
    {
        public static int ContaAparicoes(string frase, string palavra)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(frase) || string.IsNullOrWhiteSpace(palavra))
                {
                    Console.WriteLine("O Parâmetro 'Frase' e/ou 'Palavra' não pode ser vazio");
                    return 0;
                }

                if (!frase.Contains(palavra))
                {
                    Console.WriteLine($"A palavra '{palavra}' não contém na frase '{frase}'");
                    return 0;
                }

                var contador = Regex.Matches(frase, $@"\b{Regex.Escape(palavra)}\b", RegexOptions.IgnoreCase).Count;
                Console.WriteLine($"A palavra '{palavra}' apareceu na frase '{frase}' {contador}x ");
                return contador;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao filtrar aparições: {ex.Message}");
                return 0;
            }

        }
        public static void Main(string[] args)
        {
            ContaAparicoes("Banana", "a"); // 3
            ContaAparicoes("Banana", "na"); // 2
            ContaAparicoes("Banana", "ka"); // 0
            ContaAparicoes("BBBBBBBBB", "BB"); // 4
            ContaAparicoes("", "BB"); // Error
            ContaAparicoes("BB", ""); // Error
            ContaAparicoes("", " "); // Error
        }
    }
}

