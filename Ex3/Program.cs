namespace exercicio3
{
    public class Program
    {
        public static int ContaDias(string data1, string data2)
        {
            // Coloque seu código aqui
            return 0;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            ContaDias("2023-02-01", "2023-02-02"); // 1
            ContaDias("2023-02-01", "2023-02-15"); // 14
            ContaDias("2023-02-01", "2022-02-01"); // 365
            ContaDias("2022-02-01", "2023-02-01"); // 365
            ContaDias("2023-02-01", "2023-02-01"); // 0
            ContaDias("2023-02-01", "2023/02/01"); // ERRO
        }
    }
}

