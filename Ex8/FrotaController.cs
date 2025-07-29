using Ex8.Model;

namespace Ex8
{
    public class FrotaController
    {
        // TODO: A ideia aqui é simular a busca no banco de dados como se fosse um repository
        public static List<Frota> frota = new List<Frota>();

        public List<Frota> CadastrarFrota()
        {
            frota.Add(
                new Frota()
                {
                    Nome = "Cooperativa de veículos CMCar LTDA",
                    Documento = "03019756000170",
                    Automoveis = new List<Automovel>()
                        {
                            new Automovel(Tipo.Van, "VAN Ford Transit", 2008, 97080, 2, 1, "Veículo 1"),
                            new Automovel(Tipo.Van, "VAN Citroën Jumper", 2008, 95000, 2, 1,"Veículo 2"),
                            new Automovel(Tipo.Van, "VAN Citroën Jumper", 2012, 17000, 2, 1, "Veículo 3"),
                            new Automovel(Tipo.Van, "VAN Citroën Jumper", 2023, 0, 2, 1, "Veículo 4"),
                            new Automovel(Tipo.Van, "VAN Fiat Ducato", 2006, 15000, 4, 1, "Veículo 5"),
                            new Automovel(Tipo.Carro, "CARRO Fiat Palio", 2009, 15000, 2, 0, "Veículo 6"),
                            new Automovel(Tipo.Carro, "CARRO Fiat Palio", 2009, 25000, 2, 0, "Veículo 7"),
                            new Automovel(Tipo.Carro, "CARRO Ford Ká", 2015, 76560, 4, 0, "Veículo 8"),
                            new Automovel(Tipo.Carro, "CARRO Chevrolet Onix", 2010, 15000, 4, 0, "Veículo 9"),
                            new Automovel(Tipo.Moto, "MOTO Yamaha Flup", 2023, 0, 0, 0, "Veículo 10")
                        }
                });

            frota.Add(
                new Frota()
                {
                    Nome = "Consórcio de veículos CMCar S.A",
                    Documento = "26402504000121",
                    Automoveis = new List<Automovel>()
                    {
                        new Automovel(Tipo.Van, "VAN Ford Transit", 2018, 65000, 2, 1, "Veículo 11"),
                        new Automovel(Tipo.Van, "VAN Fiat Ducato", 2007, 15400, 2, 1, "Veículo 12"),
                        new Automovel(Tipo.Carro, "CARRO Fiat Palio", 2019, 35000, 2, 0, "Veículo 13"),
                        new Automovel(Tipo.Carro, "CARRO Chevrolet Onix", 2012, 65000, 4, 0, "Veículo 14"),
                        new Automovel(Tipo.Moto, "MOTO Yamaha Flup", 2023, 0, 0, 0, "Veículo 15"),
                        new Automovel(Tipo.Moto, "MOTO Yamaha Flup", 2023, 10000, 0, 0, "Veículo 16"),
                        new Automovel(Tipo.Moto, "MOTO Yamaha Flup", 2022, 5500, 0, 0, "Veículo 17"),
                        new Automovel(Tipo.Moto, "MOTO Honda CB300", 2023, 0, 0, 0, "Veículo 18")
                    }
                });

            return frota;
        }

        public void ExisteFrota()
        {
            // FIX: Aqui foi apenas uma simulação de tratamento de exceção o qual deve ser implementado nos outros métodos a fim de identificar o erro.
            try
            {
                if (frota == null)
                    throw new Exception("Frota não cadastrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }            
        }

        public void DocumentoValido(string documento)
        {
            // FIX: Aqui foi apenas uma simulação de tratamento de exceção o qual deve ser implementado nos outros métodos a fim de identificar o erro.
            try
            {
                if (string.IsNullOrWhiteSpace(documento) || documento.Count() != 14)
                    throw new Exception("Documento inválido");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");                
            }
        }

        public void FrotaEncontrada(string documento)
        {
            // FIX: Nesse caso, podemos passar para o Repository aplicando os conceitos de GetByDocumentoNumber para encontrar um dado no DB
            // TODO: Corrigir após integração com DB
            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())
                throw new Exception("Frota não encontrada ou sem automóveis.");
        }

        public int QtdVeiculosPorFrota(string documento)
        {
            // FIX: ** Esse cenário contempla apenas o caminho FELIZ, é necessário inserir implementações de exceção quando conectado com o DB
            ExisteFrota();
            DocumentoValido(documento);

            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())            
                throw new Exception("Frota não encontrada ou sem automóveis.");

            return frotaSelecionada.Automoveis.Count;
        }

        public int QtdVeiculos4Portas()
        {
            ExisteFrota();
            return frota.SelectMany(c => c.Automoveis).Count(d => d.PortaSimples + d.PortaCorrer == 4);
        }

        public int QtdAssentosFrota(string documento)
        {
            // FIX: *
            ExisteFrota();
            DocumentoValido(documento);

            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())
                throw new Exception("Frota não encontrada ou sem automóveis.");

            return frotaSelecionada.Automoveis.Sum(c => c.Assentos);
        }

        public double MediaKmFrota(string documento)
        {
            // FIX: *
            ExisteFrota();
            DocumentoValido(documento);

            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())
                throw new Exception("Frota não encontrada ou sem automóveis.");

            var mediaKm = frotaSelecionada.Automoveis.Average(a => a.Km);

            return mediaKm;
        }

        public List<string> AutomoveisMaisAntigos() {
            ExisteFrota();
            
            var anoMaisAntigo = frota.SelectMany(c => c.Automoveis).Min(c => c.Ano);
            var listaCarros = frota.SelectMany(c => c.Automoveis).Where(c => c.Ano == anoMaisAntigo).ToList();

            List<string> carros = new List<string>();
            listaCarros.ForEach(c => carros.Add(c.AutomovelId));

            return carros;
        }

        public List<string> AutomoveisMaisNovos(string documento)
        {
            ExisteFrota();
            DocumentoValido(documento);

            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())
                throw new Exception("Frota não encontrada ou sem automóveis.");

            var anoMaisNovo = frotaSelecionada.Automoveis.Max(c => c.Ano);
            var listaCarros = frotaSelecionada.Automoveis.Where(c => c.Ano == anoMaisNovo).ToList();

            List<string> carros = new List<string>();
            listaCarros.ForEach(c => carros.Add(c.AutomovelId));

            return carros;
        }

        public List<string> AutomoveisMaisRodados(string documento)
        {
            ExisteFrota();
            DocumentoValido(documento);

            var frotaSelecionada = frota.Find(c => c.Documento == documento);

            if (frotaSelecionada == null || !frotaSelecionada.Automoveis.Any())
                throw new Exception("Frota não encontrada ou sem automóveis.");

            var kmMaisRodado = frotaSelecionada.Automoveis.Max(c => c.Km);
            var listaCarros = frotaSelecionada.Automoveis.Where(c => c.Km == kmMaisRodado).ToList();

            List<string> carros = new List<string>();
            listaCarros.ForEach(c => carros.Add(c.AutomovelId));

            return carros;
        }

        public List<string> RotaComMaisQtdVans()
        {
            ExisteFrota();

            var maxVans = frota.Max(c => c.Automoveis.Count(d => d.Tipo == Tipo.Van));
            var listVans= frota.Where(c => c.Automoveis.Count(d => d.Tipo == Tipo.Van) == maxVans).ToList();

            List<string> rotas = new List<string>();
            listVans.ForEach(c => rotas.Add(c.Nome));

            return rotas;
        }
    }
}
