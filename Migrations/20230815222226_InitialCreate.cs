using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarInformation_Assignment3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarInfo",
                columns: table => new
                {
                    carNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carMade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturedYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maxSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInfo", x => x.carNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarInfo");
        }
    }
}
