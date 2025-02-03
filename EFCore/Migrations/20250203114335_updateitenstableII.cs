using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class updateitenstableII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Itens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_IdCategoria",
                table: "Itens",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Categorias_IdCategoria",
                table: "Itens",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Categorias_IdCategoria",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_IdCategoria",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Itens");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Itens",
                type: "TEXT",
                nullable: true);
        }
    }
}
