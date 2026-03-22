namespace sistemaEspecialista_IA.Models
{
    public class Regra
    {
        public int Id { get; set; }
        public int ConclusaoFatoId { get; set; }
        public string NomeDaRegra { get; set; } = string.Empty;

        public Fato? ConclusaoFato { get; set; }
        public List<RegraCondicao> Condicoes { get; set; } = new();
    }
}
