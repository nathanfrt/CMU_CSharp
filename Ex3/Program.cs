namespace exercicio3
{
    public class Program
    {
        public static int ContaDias(string data1, string data2)
        {
            try
            {
                if (!FormatoValido(data1) || !FormatoValido(data2))
                    throw new Exception("Formato de data inválido.");

                DateTime novaData1 = DateTime.Parse(data1);
                DateTime novaData2 = DateTime.Parse(data2);

                int calculoData = Math.Abs((novaData1.Date - novaData2.Date).Days);
                Console.WriteLine($"A diferença entre {FormatarData(novaData1)} e {FormatarData(novaData2)} é de {calculoData} dia(s)");

                return calculoData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return 0;
            }            
            
        }

        public static bool FormatoValido(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data))
                    throw new Exception("As datas não podem ser vazias");

                DateTime dataConvertida;

                bool formatoEhValido = DateTime.TryParseExact(data, 
                                                            "yyyy-MM-dd", 
                                                            System.Globalization.CultureInfo.InvariantCulture,
                                                            System.Globalization.DateTimeStyles.None,
                                                            out dataConvertida);

                return formatoEhValido ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return false;
            }

        }

        public static string FormatarData(DateTime data)
        {
            return data.Date.ToString("dd/MM/yyyy");
        }

        public static void Main(string[] args)
        {
            ContaDias("2023-02-01", "2023-02-02"); // 1
            ContaDias("2023-02-01", "2023-02-15"); // 14
            ContaDias("2023-02-01", "2022-02-01"); // 365
            ContaDias("2022-02-01", "2023-02-01"); // 365
            ContaDias("2023-02-01", "2023-02-01"); // 0
            ContaDias("2023-02-01", "2023/02/01"); // ERRO
            ContaDias("02-01-2023", "2023-02-01"); // ERRO
            ContaDias("23-01-2023", "2023-02-01"); // ERRO
            ContaDias("2023-02-01", "2-17-2023"); // ERRO
            ContaDias("2023-02-01", "02-17-2023"); // ERRO
        }
    }
}

