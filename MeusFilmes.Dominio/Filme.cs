namespace MeusFilmes.Dominio
{
    public class Filme
    {
        public string Id { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public GeneroEnum GeneroFilme { get; set; }
        public double Duracao { get; set; }
        public int Avaliacao { get; set; }
    }
}
