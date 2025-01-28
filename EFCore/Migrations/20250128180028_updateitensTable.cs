using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class updateitensTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_items",
                table: "tb_items");

            migrationBuilder.RenameTable(
                name: "tb_items",
                newName: "Itens");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Itens",
                table: "Itens",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Itens",
                table: "Itens");

            migrationBuilder.RenameTable(
                name: "Itens",
                newName: "tb_items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_items",
                table: "tb_items",
                column: "Id");
        }
    }
}
