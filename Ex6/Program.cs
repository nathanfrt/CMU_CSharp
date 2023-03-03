using System.Linq;

namespace exercicio6
{
    public class Program
    {
        public static List<List<int>> QuebraLista(List<int> array)
        {
            // Coloque seu código aqui
            return null;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}}
            QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}, new List<int>{10}}
            QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 4); // new List<List<int>>{new List<int>{2, 4, 6, 8}, new List<int>{10, 12, 14, 16}}
            QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 40); // new List<List<int>>{new List<int>{2, 4, 6, 8, 10, 12, 14, 16}}
            QuebraLista(new List<int>{}, 4); // new List<int>{}
        }
    }
}

