namespace Ex8.Model
{
    public class Automovel
    {
        public Tipo Tipo { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }        
        public double Km { get; set; }
        public int Assentos { get; }
        public int PortaSimples { get; set; }
        public int PortaCorrer { get; set; }
        public string AutomovelId { get; set; }


        public Automovel(Tipo tipo, string nome, int ano, double km, int portaSimples, int portaCorrer, string automovelId) 
        { 
            Tipo = tipo;
            Nome = nome;
            Ano = ano;
            Km = km;
            PortaSimples = portaSimples;
            PortaCorrer = portaCorrer;
            AutomovelId = automovelId;
            Assentos = Tipo == Tipo.Moto ? 2 : Tipo == Tipo.Carro ? 5 : 12;
        }
    }
}
