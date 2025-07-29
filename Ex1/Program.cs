namespace exercicio1
{
    public class Program
    {
        public static List<string> FiltraTerminadasEmA(List<string> array)
        {
            try
            {
                if (array == null || array.Count == 0)                
                    throw new Exception("A lista recebida é nula ou vazia.");                    
                
                var acentos = new[] { "á", "à", "â", "ã", "ä", "a" };

                var result = array.Where(c => !string.IsNullOrWhiteSpace(c) &&
                                        acentos.Any(d => c.EndsWith(d, StringComparison.OrdinalIgnoreCase))).ToList();

                if (result.Count == 0)
                    throw new Exception("Nenhuma palavra termina com a letra 'a'.");

                Console.WriteLine(string.Join(", ", result.FindAll(c => !string.IsNullOrWhiteSpace(c))));
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return new List<string>();
            }
        }

        public static void Main(string[] args)
        {            
            FiltraTerminadasEmA(new List<string> { "Pera", "Maçã", "Banana", "Uva", "Abacate" }); // new List<string> {"Pera", "Banana", "Uva"}
            FiltraTerminadasEmA(new List<string> { "BANANA", "AZEITE", "Sacola", "MERCADO" }); // new List<string> {"BANANA", "Sacola"} 
            FiltraTerminadasEmA(new List<string> { "Caderno", "Corretivo", "Computador", "Lápis", "Marcador" });
            FiltraTerminadasEmA(new List<string> { "Per$", "Maç4", "Banan@", "Uva.", "Uva", "Abacat!" });
            FiltraTerminadasEmA(new List<string>());
        }
    }
}

