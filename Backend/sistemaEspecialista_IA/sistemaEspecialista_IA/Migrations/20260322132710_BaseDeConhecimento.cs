using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemaEspecialista_IA.Migrations
{
    /// <inheritdoc />
    public partial class BaseDeConhecimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Chave = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConclusaoFatoId = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeDaRegra = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regras_Fatos_ConclusaoFatoId",
                        column: x => x.ConclusaoFatoId,
                        principalTable: "Fatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegraCondicoes",
                columns: table => new
                {
                    RegraId = table.Column<int>(type: "INTEGER", nullable: false),
                    FatoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegraCondicoes", x => new { x.RegraId, x.FatoId });
                    table.ForeignKey(
                        name: "FK_RegraCondicoes_Fatos_FatoId",
                        column: x => x.FatoId,
                        principalTable: "Fatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegraCondicoes_Regras_RegraId",
                        column: x => x.RegraId,
                        principalTable: "Regras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fatos",
                columns: new[] { "Id", "Chave", "Descricao" },
                values: new object[,]
                {
                    { 1, "tem_pelos", "Tem pelos" },
                    { 2, "da_leite", "Dá leite" },
                    { 3, "tem_penas", "Tem penas" },
                    { 4, "pele_umida", "Pele úmida" },
                    { 5, "respira_agua", "Respira debaixo d'água" },
                    { 6, "tem_escamas", "Tem escamas" },
                    { 7, "late", "Late" },
                    { 8, "mia", "Mia" },
                    { 9, "muge", "Muge" },
                    { 10, "relincha", "Relincha" },
                    { 11, "ruge", "Ruge" },
                    { 12, "uiva", "Uiva" },
                    { 13, "come_banana", "Come banana" },
                    { 14, "tem_tromba", "Tem tromba" },
                    { 15, "pescoco_longo", "Pescoço longo" },
                    { 16, "dorme_cabeca_baixo", "Dorme de cabeça para baixo" },
                    { 17, "solta_esguicho", "Solta esguicho de água" },
                    { 18, "listras_laranja_pretas", "Listras laranjas e pretas" },
                    { 19, "listras_brancas_pretas", "Listras brancas e pretas" },
                    { 20, "manchas_escuras", "Manchas escuras" },
                    { 21, "cacareja", "Cacareja" },
                    { 22, "faz_quack", "Faz quack" },
                    { 23, "pernas_longas", "Pernas longas" },
                    { 24, "nao_voa", "Não voa" },
                    { 25, "vive_no_gelo", "Vive no gelo" },
                    { 26, "caca_do_alto", "Caça voando do alto" },
                    { 27, "dentes_afiados", "Tem dentes afiados" },
                    { 28, "nao_tem_pernas", "Não tem pernas" },
                    { 29, "casco_duro", "Tem casco duro" },
                    { 30, "faz_croac", "Faz croac" },
                    { 31, "cor_laranja_branca", "Cor laranja e branca" },
                    { 32, "e_mamifero", "É Mamífero" },
                    { 33, "e_ave", "É Ave" },
                    { 34, "e_reptil", "É Réptil" },
                    { 35, "e_anfibio", "É Anfíbio" },
                    { 36, "e_peixe", "É Peixe" },
                    { 37, "cachorro", "Cachorro" },
                    { 38, "gato", "Gato" },
                    { 39, "vaca", "Vaca" },
                    { 40, "cavalo", "Cavalo" },
                    { 41, "leao", "Leão" },
                    { 42, "tigre", "Tigre" },
                    { 43, "guepardo", "Guepardo" },
                    { 44, "lobo", "Lobo" },
                    { 45, "macaco", "Macaco" },
                    { 46, "elefante", "Elefante" },
                    { 47, "girafa", "Girafa" },
                    { 48, "morcego", "Morcego" },
                    { 49, "baleia", "Baleia" },
                    { 50, "zebra", "Zebra" },
                    { 51, "galinha", "Galinha" },
                    { 52, "pato", "Pato" },
                    { 53, "avestruz", "Avestruz" },
                    { 54, "pinguim", "Pinguim" },
                    { 55, "aguia", "Águia" },
                    { 56, "crocodilo", "Crocodilo" },
                    { 57, "cobra", "Cobra" },
                    { 58, "tartaruga", "Tartaruga" },
                    { 59, "sapo", "Sapo" },
                    { 60, "tubarao", "Tubarão" },
                    { 61, "peixe_palhaco", "Peixe-Palhaço" }
                });

            migrationBuilder.InsertData(
                table: "Regras",
                columns: new[] { "Id", "ConclusaoFatoId", "NomeDaRegra" },
                values: new object[,]
                {
                    { 1, 32, "R1" },
                    { 2, 32, "R2" },
                    { 3, 33, "R3" },
                    { 4, 35, "R4" },
                    { 5, 36, "R5" },
                    { 6, 34, "R6" },
                    { 7, 34, "R7" },
                    { 10, 37, "R10" },
                    { 11, 38, "R11" },
                    { 12, 39, "R12" },
                    { 13, 40, "R13" },
                    { 14, 41, "R14" },
                    { 15, 42, "R15" },
                    { 16, 43, "R16" },
                    { 17, 44, "R17" },
                    { 18, 45, "R18" },
                    { 19, 46, "R19" },
                    { 20, 47, "R20" },
                    { 21, 48, "R21" },
                    { 22, 49, "R22" },
                    { 23, 50, "R23" },
                    { 30, 51, "R30" },
                    { 31, 52, "R31" },
                    { 32, 53, "R32" },
                    { 33, 54, "R33" },
                    { 34, 55, "R34" },
                    { 40, 56, "R40" },
                    { 41, 57, "R41" },
                    { 42, 58, "R42" },
                    { 50, 59, "R50" },
                    { 60, 60, "R60" },
                    { 61, 61, "R61" }
                });

            migrationBuilder.InsertData(
                table: "RegraCondicoes",
                columns: new[] { "FatoId", "RegraId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 29, 7 },
                    { 7, 10 },
                    { 32, 10 },
                    { 8, 11 },
                    { 32, 11 },
                    { 9, 12 },
                    { 32, 12 },
                    { 10, 13 },
                    { 32, 13 },
                    { 11, 14 },
                    { 32, 14 },
                    { 18, 15 },
                    { 32, 15 },
                    { 20, 16 },
                    { 32, 16 },
                    { 12, 17 },
                    { 32, 17 },
                    { 13, 18 },
                    { 32, 18 },
                    { 14, 19 },
                    { 32, 19 },
                    { 15, 20 },
                    { 32, 20 },
                    { 16, 21 },
                    { 32, 21 },
                    { 17, 22 },
                    { 32, 22 },
                    { 19, 23 },
                    { 32, 23 },
                    { 21, 30 },
                    { 33, 30 },
                    { 22, 31 },
                    { 33, 31 },
                    { 23, 32 },
                    { 24, 32 },
                    { 33, 32 },
                    { 25, 33 },
                    { 33, 33 },
                    { 26, 34 },
                    { 33, 34 },
                    { 27, 40 },
                    { 34, 40 },
                    { 28, 41 },
                    { 34, 41 },
                    { 29, 42 },
                    { 34, 42 },
                    { 30, 50 },
                    { 35, 50 },
                    { 27, 60 },
                    { 36, 60 },
                    { 31, 61 },
                    { 36, 61 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegraCondicoes_FatoId",
                table: "RegraCondicoes",
                column: "FatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Regras_ConclusaoFatoId",
                table: "Regras",
                column: "ConclusaoFatoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegraCondicoes");

            migrationBuilder.DropTable(
                name: "Regras");

            migrationBuilder.DropTable(
                name: "Fatos");
        }
    }
}
