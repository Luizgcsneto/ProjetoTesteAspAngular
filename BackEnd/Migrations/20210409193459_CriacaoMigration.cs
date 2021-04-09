using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class CriacaoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    CursoSuperior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portfolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PretensaoSalarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraAteQuatro = table.Column<bool>(type: "bit", nullable: false),
                    HoraQuatroAteSeis = table.Column<bool>(type: "bit", nullable: false),
                    HoraSeisAteOito = table.Column<bool>(type: "bit", nullable: false),
                    HoraAcimaOito = table.Column<bool>(type: "bit", nullable: false),
                    HorarioPelaManha = table.Column<bool>(type: "bit", nullable: false),
                    HorarioPelaTarde = table.Column<bool>(type: "bit", nullable: false),
                    HorarioPelaNoite = table.Column<bool>(type: "bit", nullable: false),
                    HorarioComercial = table.Column<bool>(type: "bit", nullable: false),
                    HorarioPelaMadrugada = table.Column<bool>(type: "bit", nullable: false),
                    HorarioFinalDeSemana = table.Column<bool>(type: "bit", nullable: false),
                    DisponibilidadeViagem = table.Column<bool>(type: "bit", nullable: false),
                    BancoNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContaPoupanca = table.Column<bool>(type: "bit", nullable: false),
                    ContaCorrente = table.Column<bool>(type: "bit", nullable: false),
                    BancoAgencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BancoNumConta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjetoCRUDlink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programadores");
        }
    }
}
