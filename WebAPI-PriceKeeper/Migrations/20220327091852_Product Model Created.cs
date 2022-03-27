using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_PriceKeeper.Migrations
{
    public partial class ProductModelCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    priceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    amount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    total = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
