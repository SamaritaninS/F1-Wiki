using Microsoft.EntityFrameworkCore.Migrations;

namespace F1.Migrations
{
    public partial class _3Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Driver_FirstDriverId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Driver_SecondDriverId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_FirstDriverId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_SecondDriverId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "FirstDriverId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "SecondDriverId",
                table: "Team");

            migrationBuilder.AddColumn<string>(
                name: "FirstDriver",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecondDriver",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Driver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RaceResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laps = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceResult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceResult");

            migrationBuilder.DropColumn(
                name: "FirstDriver",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "SecondDriver",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "Driver");

            migrationBuilder.AddColumn<int>(
                name: "FirstDriverId",
                table: "Team",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondDriverId",
                table: "Team",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_FirstDriverId",
                table: "Team",
                column: "FirstDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_SecondDriverId",
                table: "Team",
                column: "SecondDriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Driver_FirstDriverId",
                table: "Team",
                column: "FirstDriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Driver_SecondDriverId",
                table: "Team",
                column: "SecondDriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
