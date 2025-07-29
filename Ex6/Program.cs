namespace exercicio6
{
    public class Program
    {
        public static List<List<int>>?QuebraLista(List<int> array, int y)
        {
            try
            {
                if (array == null || array.Count < 1)
                    throw new Exception("A lista não pode ser nula ou vazia");

                var fullLista = new List<List<int>>();

                for (int i = 0; i < array.Count; i += y)
                {
                    var elementosLista = array.Skip(i).Take(y).ToList();
                    fullLista.Add(elementosLista);
                }

                if (fullLista != null && fullLista.Count > 0)
                {
                    fullLista.ForEach(c =>
                    {
                        Console.Write($"[{string.Join(',', c)}]");
                    });
                    Console.WriteLine();
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return null;
            }
        }

        public static void Main(string[] args)
        {
            QuebraLista(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}}
            QuebraLista(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}, new List<int>{10}}
            QuebraLista(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 }, 4); // new List<List<int>>{new List<int>{2, 4, 6, 8}, new List<int>{10, 12, 14, 16}}
            QuebraLista(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 }, 40); // new List<List<int>>{new List<int>{2, 4, 6, 8, 10, 12, 14, 16}}
            QuebraLista(new List<int>{}, 4); // new List<int>{}
            QuebraLista(new List<int> { 1, 2 , 3, 4 }, 1); // new List<int>{1}, new List<int>{2}, new List<int>{3}, new List<int>{4}
        }
    }
}

