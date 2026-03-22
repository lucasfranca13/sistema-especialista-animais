namespace sistemaEspecialista_IA.Models
{
    public class RegraCondicao
    {
        public int RegraId { get; set; }
        public int FatoId { get; set; }

        public Regra? Regra { get; set; }
        public Fato? Fato { get; set; }
    }
}
