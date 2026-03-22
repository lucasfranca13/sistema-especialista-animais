using Microsoft.EntityFrameworkCore;
using sistemaEspecialista_IA.Models;

namespace sistemaEspecialista_IA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Fato> Fatos { get; set; }
        public DbSet<Regra> Regras { get; set; }
        public DbSet<RegraCondicao> RegraCondicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegraCondicao>()
                .HasKey(rc => new { rc.RegraId, rc.FatoId });

            modelBuilder.Entity<Regra>()
                .HasOne(r => r.ConclusaoFato)
                .WithMany()
                .HasForeignKey(r => r.ConclusaoFatoId);

            modelBuilder.Entity<RegraCondicao>()
                .HasOne(rc => rc.Fato)
                .WithMany()
                .HasForeignKey(rc => rc.FatoId);

            // ==========================================
            // BASE DE CONHECIMENTO (25 Animais)
            // ==========================================

            // FATOS
            modelBuilder.Entity<Fato>().HasData(
                // Características Básicas
                new Fato { Id = 1, Chave = "tem_pelos", Descricao = "Tem pelos" },
                new Fato { Id = 2, Chave = "da_leite", Descricao = "Dá leite" },
                new Fato { Id = 3, Chave = "tem_penas", Descricao = "Tem penas" },
                new Fato { Id = 4, Chave = "pele_umida", Descricao = "Pele úmida" },
                new Fato { Id = 5, Chave = "respira_agua", Descricao = "Respira debaixo d'água" },
                new Fato { Id = 6, Chave = "tem_escamas", Descricao = "Tem escamas" },

                // Características Unicas / Secundárias
                new Fato { Id = 7, Chave = "late", Descricao = "Late" },
                new Fato { Id = 8, Chave = "mia", Descricao = "Mia" },
                new Fato { Id = 9, Chave = "muge", Descricao = "Muge" },
                new Fato { Id = 10, Chave = "relincha", Descricao = "Relincha" },
                new Fato { Id = 11, Chave = "ruge", Descricao = "Ruge" },
                new Fato { Id = 12, Chave = "uiva", Descricao = "Uiva" },
                new Fato { Id = 13, Chave = "come_banana", Descricao = "Come banana" },
                new Fato { Id = 14, Chave = "tem_tromba", Descricao = "Tem tromba" },
                new Fato { Id = 15, Chave = "pescoco_longo", Descricao = "Pescoço longo" },
                new Fato { Id = 16, Chave = "dorme_cabeca_baixo", Descricao = "Dorme de cabeça para baixo" },
                new Fato { Id = 17, Chave = "solta_esguicho", Descricao = "Solta esguicho de água" },
                new Fato { Id = 18, Chave = "listras_laranja_pretas", Descricao = "Listras laranjas e pretas" },
                new Fato { Id = 19, Chave = "listras_brancas_pretas", Descricao = "Listras brancas e pretas" },
                new Fato { Id = 20, Chave = "manchas_escuras", Descricao = "Manchas escuras" },
                new Fato { Id = 21, Chave = "cacareja", Descricao = "Cacareja" },
                new Fato { Id = 22, Chave = "faz_quack", Descricao = "Faz quack" },
                new Fato { Id = 23, Chave = "pernas_longas", Descricao = "Pernas longas" },
                new Fato { Id = 24, Chave = "nao_voa", Descricao = "Não voa" },
                new Fato { Id = 25, Chave = "vive_no_gelo", Descricao = "Vive no gelo" },
                new Fato { Id = 26, Chave = "caca_do_alto", Descricao = "Caça voando do alto" },
                new Fato { Id = 27, Chave = "dentes_afiados", Descricao = "Tem dentes afiados" },
                new Fato { Id = 28, Chave = "nao_tem_pernas", Descricao = "Não tem pernas" },
                new Fato { Id = 29, Chave = "casco_duro", Descricao = "Tem casco duro" },
                new Fato { Id = 30, Chave = "faz_croac", Descricao = "Faz croac" },
                new Fato { Id = 31, Chave = "cor_laranja_branca", Descricao = "Cor laranja e branca" },

                // Categorias Intermediárias
                new Fato { Id = 32, Chave = "e_mamifero", Descricao = "É Mamífero" },
                new Fato { Id = 33, Chave = "e_ave", Descricao = "É Ave" },
                new Fato { Id = 34, Chave = "e_reptil", Descricao = "É Réptil" },
                new Fato { Id = 35, Chave = "e_anfibio", Descricao = "É Anfíbio" },
                new Fato { Id = 36, Chave = "e_peixe", Descricao = "É Peixe" },

                // Conclusões Finais - Os 25 Animais
                new Fato { Id = 37, Chave = "cachorro", Descricao = "Cachorro" },
                new Fato { Id = 38, Chave = "gato", Descricao = "Gato" },
                new Fato { Id = 39, Chave = "vaca", Descricao = "Vaca" },
                new Fato { Id = 40, Chave = "cavalo", Descricao = "Cavalo" },
                new Fato { Id = 41, Chave = "leao", Descricao = "Leão" },
                new Fato { Id = 42, Chave = "tigre", Descricao = "Tigre" },
                new Fato { Id = 43, Chave = "guepardo", Descricao = "Guepardo" },
                new Fato { Id = 44, Chave = "lobo", Descricao = "Lobo" },
                new Fato { Id = 45, Chave = "macaco", Descricao = "Macaco" },
                new Fato { Id = 46, Chave = "elefante", Descricao = "Elefante" },
                new Fato { Id = 47, Chave = "girafa", Descricao = "Girafa" },
                new Fato { Id = 48, Chave = "morcego", Descricao = "Morcego" },
                new Fato { Id = 49, Chave = "baleia", Descricao = "Baleia" },
                new Fato { Id = 50, Chave = "zebra", Descricao = "Zebra" },
                new Fato { Id = 51, Chave = "galinha", Descricao = "Galinha" },
                new Fato { Id = 52, Chave = "pato", Descricao = "Pato" },
                new Fato { Id = 53, Chave = "avestruz", Descricao = "Avestruz" },
                new Fato { Id = 54, Chave = "pinguim", Descricao = "Pinguim" },
                new Fato { Id = 55, Chave = "aguia", Descricao = "Águia" },
                new Fato { Id = 56, Chave = "crocodilo", Descricao = "Crocodilo" },
                new Fato { Id = 57, Chave = "cobra", Descricao = "Cobra" },
                new Fato { Id = 58, Chave = "tartaruga", Descricao = "Tartaruga" },
                new Fato { Id = 59, Chave = "sapo", Descricao = "Sapo" },
                new Fato { Id = 60, Chave = "tubarao", Descricao = "Tubarão" },
                new Fato { Id = 61, Chave = "peixe_palhaco", Descricao = "Peixe-Palhaço" }
            );

            // REGRAS
            modelBuilder.Entity<Regra>().HasData(
                // Regras Base (Classes)
                new Regra { Id = 1, NomeDaRegra = "R1", ConclusaoFatoId = 32 }, // Mamífero (pelos)
                new Regra { Id = 2, NomeDaRegra = "R2", ConclusaoFatoId = 32 }, // Mamífero (leite)
                new Regra { Id = 3, NomeDaRegra = "R3", ConclusaoFatoId = 33 }, // Ave
                new Regra { Id = 4, NomeDaRegra = "R4", ConclusaoFatoId = 35 }, // Anfíbio
                new Regra { Id = 5, NomeDaRegra = "R5", ConclusaoFatoId = 36 }, // Peixe
                new Regra { Id = 6, NomeDaRegra = "R6", ConclusaoFatoId = 34 }, // Réptil (escamas)
                new Regra { Id = 7, NomeDaRegra = "R7", ConclusaoFatoId = 34 }, // Réptil (casco)

                // Regras Finais (Mamíferos)
                new Regra { Id = 10, NomeDaRegra = "R10", ConclusaoFatoId = 37 }, // Cachorro
                new Regra { Id = 11, NomeDaRegra = "R11", ConclusaoFatoId = 38 }, // Gato
                new Regra { Id = 12, NomeDaRegra = "R12", ConclusaoFatoId = 39 }, // Vaca
                new Regra { Id = 13, NomeDaRegra = "R13", ConclusaoFatoId = 40 }, // Cavalo
                new Regra { Id = 14, NomeDaRegra = "R14", ConclusaoFatoId = 41 }, // Leão
                new Regra { Id = 15, NomeDaRegra = "R15", ConclusaoFatoId = 42 }, // Tigre
                new Regra { Id = 16, NomeDaRegra = "R16", ConclusaoFatoId = 43 }, // Guepardo
                new Regra { Id = 17, NomeDaRegra = "R17", ConclusaoFatoId = 44 }, // Lobo
                new Regra { Id = 18, NomeDaRegra = "R18", ConclusaoFatoId = 45 }, // Macaco
                new Regra { Id = 19, NomeDaRegra = "R19", ConclusaoFatoId = 46 }, // Elefante
                new Regra { Id = 20, NomeDaRegra = "R20", ConclusaoFatoId = 47 }, // Girafa
                new Regra { Id = 21, NomeDaRegra = "R21", ConclusaoFatoId = 48 }, // Morcego
                new Regra { Id = 22, NomeDaRegra = "R22", ConclusaoFatoId = 49 }, // Baleia
                new Regra { Id = 23, NomeDaRegra = "R23", ConclusaoFatoId = 50 }, // Zebra

                // Regras Finais (Aves)
                new Regra { Id = 30, NomeDaRegra = "R30", ConclusaoFatoId = 51 }, // Galinha
                new Regra { Id = 31, NomeDaRegra = "R31", ConclusaoFatoId = 52 }, // Pato
                new Regra { Id = 32, NomeDaRegra = "R32", ConclusaoFatoId = 53 }, // Avestruz
                new Regra { Id = 33, NomeDaRegra = "R33", ConclusaoFatoId = 54 }, // Pinguim
                new Regra { Id = 34, NomeDaRegra = "R34", ConclusaoFatoId = 55 }, // Águia

                // Regras Finais (Répteis, Anfíbio, Peixes)
                new Regra { Id = 40, NomeDaRegra = "R40", ConclusaoFatoId = 56 }, // Crocodilo
                new Regra { Id = 41, NomeDaRegra = "R41", ConclusaoFatoId = 57 }, // Cobra
                new Regra { Id = 42, NomeDaRegra = "R42", ConclusaoFatoId = 58 }, // Tartaruga
                new Regra { Id = 50, NomeDaRegra = "R50", ConclusaoFatoId = 59 }, // Sapo
                new Regra { Id = 60, NomeDaRegra = "R60", ConclusaoFatoId = 60 }, // Tubarão
                new Regra { Id = 61, NomeDaRegra = "R61", ConclusaoFatoId = 61 }  // Peixe-Palhaço
            );

            // CONDIÇÕES
            modelBuilder.Entity<RegraCondicao>().HasData(
                // Condições Base
                new RegraCondicao { RegraId = 1, FatoId = 1 }, // Tem pelos -> Mamífero
                new RegraCondicao { RegraId = 2, FatoId = 2 }, // Dá leite -> Mamífero
                new RegraCondicao { RegraId = 3, FatoId = 3 }, // Tem penas -> Ave
                new RegraCondicao { RegraId = 4, FatoId = 4 }, // Pele umida -> Anfíbio
                new RegraCondicao { RegraId = 5, FatoId = 5 }, // Respira agua -> Peixe
                new RegraCondicao { RegraId = 6, FatoId = 6 }, // Tem escamas -> Réptil
                new RegraCondicao { RegraId = 7, FatoId = 29 }, // Casco duro -> Réptil

                // Condições Mamíferos
                new RegraCondicao { RegraId = 10, FatoId = 32 }, new RegraCondicao { RegraId = 10, FatoId = 7 }, // Cachorro
                new RegraCondicao { RegraId = 11, FatoId = 32 }, new RegraCondicao { RegraId = 11, FatoId = 8 }, // Gato
                new RegraCondicao { RegraId = 12, FatoId = 32 }, new RegraCondicao { RegraId = 12, FatoId = 9 }, // Vaca
                new RegraCondicao { RegraId = 13, FatoId = 32 }, new RegraCondicao { RegraId = 13, FatoId = 10 }, // Cavalo
                new RegraCondicao { RegraId = 14, FatoId = 32 }, new RegraCondicao { RegraId = 14, FatoId = 11 }, // Leão
                new RegraCondicao { RegraId = 15, FatoId = 32 }, new RegraCondicao { RegraId = 15, FatoId = 18 }, // Tigre
                new RegraCondicao { RegraId = 16, FatoId = 32 }, new RegraCondicao { RegraId = 16, FatoId = 20 }, // Guepardo
                new RegraCondicao { RegraId = 17, FatoId = 32 }, new RegraCondicao { RegraId = 17, FatoId = 12 }, // Lobo
                new RegraCondicao { RegraId = 18, FatoId = 32 }, new RegraCondicao { RegraId = 18, FatoId = 13 }, // Macaco
                new RegraCondicao { RegraId = 19, FatoId = 32 }, new RegraCondicao { RegraId = 19, FatoId = 14 }, // Elefante
                new RegraCondicao { RegraId = 20, FatoId = 32 }, new RegraCondicao { RegraId = 20, FatoId = 15 }, // Girafa
                new RegraCondicao { RegraId = 21, FatoId = 32 }, new RegraCondicao { RegraId = 21, FatoId = 16 }, // Morcego
                new RegraCondicao { RegraId = 22, FatoId = 32 }, new RegraCondicao { RegraId = 22, FatoId = 17 }, // Baleia
                new RegraCondicao { RegraId = 23, FatoId = 32 }, new RegraCondicao { RegraId = 23, FatoId = 19 }, // Zebra

                // Condições Aves
                new RegraCondicao { RegraId = 30, FatoId = 33 }, new RegraCondicao { RegraId = 30, FatoId = 21 }, // Galinha
                new RegraCondicao { RegraId = 31, FatoId = 33 }, new RegraCondicao { RegraId = 31, FatoId = 22 }, // Pato
                new RegraCondicao { RegraId = 32, FatoId = 33 }, new RegraCondicao { RegraId = 32, FatoId = 23 }, new RegraCondicao { RegraId = 32, FatoId = 24 }, // Avestruz
                new RegraCondicao { RegraId = 33, FatoId = 33 }, new RegraCondicao { RegraId = 33, FatoId = 25 }, // Pinguim
                new RegraCondicao { RegraId = 34, FatoId = 33 }, new RegraCondicao { RegraId = 34, FatoId = 26 }, // Águia

                // Condições Répteis
                new RegraCondicao { RegraId = 40, FatoId = 34 }, new RegraCondicao { RegraId = 40, FatoId = 27 }, // Crocodilo
                new RegraCondicao { RegraId = 41, FatoId = 34 }, new RegraCondicao { RegraId = 41, FatoId = 28 }, // Cobra
                new RegraCondicao { RegraId = 42, FatoId = 34 }, new RegraCondicao { RegraId = 42, FatoId = 29 }, // Tartaruga

                // Condições Anfíbios e Peixes 
                new RegraCondicao { RegraId = 50, FatoId = 35 }, new RegraCondicao { RegraId = 50, FatoId = 30 }, // Sapo
                new RegraCondicao { RegraId = 60, FatoId = 36 }, new RegraCondicao { RegraId = 60, FatoId = 27 }, // Tubarão
                new RegraCondicao { RegraId = 61, FatoId = 36 }, new RegraCondicao { RegraId = 61, FatoId = 31 }  // Peixe-Palhaço
            );
        }
    }
}
