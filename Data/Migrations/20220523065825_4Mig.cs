using Microsoft.EntityFrameworkCore.Migrations;

namespace F1.Migrations
{
    public partial class _4Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "New",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_New", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: false),
                    RaceDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualiDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P1Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P2Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P3Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    Place1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "New");

            migrationBuilder.DropTable(
                name: "Race");
        }
    }
}
