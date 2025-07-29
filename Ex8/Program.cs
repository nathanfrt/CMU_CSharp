using Ex8;
using Ex8.Model;

namespace exercicio8
{
    public class Program
    {       

        public static void Main(string[] args)
        {
            // Resolva aqui, utilizando as classes criadas, os items a seguir:

            try
            {
                var controller = new FrotaController();
                List<Frota> frotas = controller.CadastrarFrota();

                // a) A quantidade de veículos da frota 1. Resposta: 10
                Console.WriteLine(controller.QtdVeiculosPorFrota("03019756000170"));

                // b) A quantidade de carros com 4 portas na empresa. Resposta: 3
                Console.WriteLine(controller.QtdVeiculos4Portas());

                // c) O total de lugares (capacidade) disponíveis da frota 1. Resposta: 82
                Console.WriteLine(controller.QtdAssentosFrota("03019756000170"));

                // d) A média de quilômetros rodados de todos os veículos da frota 2. Resposta: 24.487,5
                Console.WriteLine(controller.MediaKmFrota("26402504000121"));

                // e) O(s) veículo(s) mais novo(s) da frota 1 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 4 e Veiculo 10
                var maisNovos = controller.AutomoveisMaisNovos("03019756000170");
                maisNovos.ForEach(c => Console.WriteLine(string.Join(",", c)));

                // f) O(s) veículo(s) mais rodado(s) da frota 2 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 11 e Veiculo 14
                var maisRodados = controller.AutomoveisMaisRodados("26402504000121");
                maisRodados.ForEach(c => Console.WriteLine(string.Join(",", c)));

                // g) O(s) veículo(s) mais antigo(s) da empresa (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 5
                var maisAntigos = controller.AutomoveisMaisAntigos();
                maisAntigos.ForEach(c => Console.WriteLine(string.Join(",", c)));

                // h) A frota com a maior quantidade de vans (retornar em forma de lista, pois pode haver mais de um) Resposta: Frota 1
                var qtdVans = controller.RotaComMaisQtdVans();
                qtdVans.ForEach(c => Console.WriteLine(string.Join(",", c)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.ToString()} ");                
            }
        }
    }
}

