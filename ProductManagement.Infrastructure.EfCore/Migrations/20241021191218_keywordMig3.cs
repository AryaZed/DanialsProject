using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductManagement.Infrastructure.EfCore.Migrations
{
    public partial class keywordMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
    name: "IsRemoved",
    table: "Products",
    type: "bit",
    nullable: false,
    defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
    name: "IsRemoved",
    table: "Products");
        }
    }
}
