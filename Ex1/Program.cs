using System.Linq;

namespace exercicio1
{
    public class Program
    {
        public static List<string> FiltraTerminadasEmA(List<string> array)
        {
            // Coloque seu código aqui
            return null;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            FiltraTerminadasEmA(new List<string> {"Pera", "Maçã", "Banana", "Uva", "Abacate"}); // new List<string> {"Pera", "Banana", "Uva"}
            FiltraTerminadasEmA(new List<string> {"BANANA", "AZEITE", "Sacola", "MERCADO"}); // new List<string> {"BANANA", "Sacola"}
            FiltraTerminadasEmA(new List<string> {}); // new List<string> {}
        }
    }
}

