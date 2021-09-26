using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Core.Migrations
{
    public partial class Add_FoodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PreparationTime = table.Column<int>(nullable: false),
                    Complexity = table.Column<int>(nullable: false),
                    CookingApparatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_CookingAparatures_CookingApparatusId",
                        column: x => x.CookingApparatusId,
                        principalTable: "CookingAparatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CookingApparatusId",
                table: "Foods",
                column: "CookingApparatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
