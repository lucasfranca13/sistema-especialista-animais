using Microsoft.EntityFrameworkCore;
using sistemaEspecialista_IA.Data;
using sistemaEspecialista_IA.Models;

namespace sistemaEspecialista_IA.Services
{
    public class MotorDeInferencia
    {
        private readonly AppDbContext _context;

        public MotorDeInferencia(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResultadoInferencia> ExecutarInferenciaAsync(List<string> chavesFatosIniciais)
        {
            var baseRegras = await _context.Regras
                .Include(r => r.Condicoes).ThenInclude(c => c.Fato)
                .Include(r => r.ConclusaoFato)
                .ToListAsync();

            var fatosAtivos = new HashSet<string>(chavesFatosIniciais);
            var regrasDisparadas = new List<string>();
            bool novaConclusaoGerada;

            // 1. O Laço do Encadeamento para Frente
            do
            {
                novaConclusaoGerada = false;

                foreach (var regra in baseRegras)
                {
                    if (!fatosAtivos.Contains(regra.ConclusaoFato!.Chave))
                    {
                        bool atendeTodasCondicoes = regra.Condicoes.All(c => fatosAtivos.Contains(c.Fato!.Chave));

                        if (atendeTodasCondicoes)
                        {
                            fatosAtivos.Add(regra.ConclusaoFato.Chave);

                            var condicoesTexto = string.Join(" e ", regra.Condicoes.Select(c => c.Fato!.Descricao));
                            regrasDisparadas.Add($"{regra.NomeDaRegra} disparou: Se {condicoesTexto} então deduz {regra.ConclusaoFato.Descricao}");

                            novaConclusaoGerada = true;
                        }
                    }
                }
            } while (novaConclusaoGerada);

            // 2. Trava de Segurança Biológica (Impede "Frankensteins")
            var classesBiologicas = new List<string> { "e_mamifero", "e_ave", "e_reptil", "e_anfibio", "e_peixe" };
            var classesAtivadas = fatosAtivos.Intersect(classesBiologicas).ToList();

            if (classesAtivadas.Count > 1)
            {
                return new ResultadoInferencia
                {
                    FatosFinais = new List<string> { "erro_conflito" },
                    Explicacao = new List<string> { $"ERRO LÓGICO: Fatos conflitantes. O sistema ativou simultaneamente as classes: {string.Join(" e ", classesAtivadas.Select(c => $"'{c}'"))}. Isso viola as regras do domínio. Limpe os fatos e tente novamente com características de apenas um animal." }
                };
            }

            // 3. Retorna o resultado normal
            return new ResultadoInferencia
            {
                FatosFinais = fatosAtivos.ToList(),
                Explicacao = regrasDisparadas
            };
        }
    }

    public class ResultadoInferencia
    {
        public List<string> FatosFinais { get; set; } = new();
        public List<string> Explicacao { get; set; } = new();
    }
}