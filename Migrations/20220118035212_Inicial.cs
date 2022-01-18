using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIMotos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adventures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PotênciaCV = table.Column<double>(type: "float", nullable: false),
                    TorqueKfgm = table.Column<int>(type: "int", nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Bateria = table.Column<double>(type: "float", nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tanque = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adventures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OffRoads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PotênciaCV = table.Column<double>(type: "float", nullable: false),
                    TorqueKfgm = table.Column<int>(type: "int", nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Bateria = table.Column<double>(type: "float", nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tanque = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffRoads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PotênciaCV = table.Column<double>(type: "float", nullable: false),
                    TorqueKfgm = table.Column<int>(type: "int", nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Bateria = table.Column<double>(type: "float", nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tanque = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PotênciaCV = table.Column<double>(type: "float", nullable: false),
                    TorqueKfgm = table.Column<int>(type: "int", nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Bateria = table.Column<double>(type: "float", nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tanque = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tourings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PotênciaCV = table.Column<double>(type: "float", nullable: false),
                    TorqueKfgm = table.Column<int>(type: "int", nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    Bateria = table.Column<double>(type: "float", nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tanque = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adventures");

            migrationBuilder.DropTable(
                name: "OffRoads");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Tourings");
        }
    }
}
