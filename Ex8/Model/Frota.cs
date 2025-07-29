namespace Ex8.Model
{
    public class Frota
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public List<Automovel> Automoveis { get; set; }
        public string FrotaId { get;}

        public Frota(string nome, string documento, List<Automovel> automovels)
        {
            Nome = nome;
            Documento = documento;
            Automoveis = automovels;            
            FrotaId = Guid.NewGuid().ToString();
        }

        public Frota() { }
    }
}
