namespace exercicio2
{
    public class Program
    {
        public static int ContaAparicoes(string frase, string palavra)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(frase) || string.IsNullOrWhiteSpace(palavra))                
                    throw new Exception("O parâmetro 'frase' e/ou 'palavra' não pode ser vazio.");

                int contador = 0, index = 0;                

                while ((index = frase.IndexOf(palavra, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    contador++;
                    index++; 
                }

                Console.WriteLine($"A palavra '{palavra}' apareceu na frase '{frase}' {contador}x");
                return contador;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
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

