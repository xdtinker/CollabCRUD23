using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollabCRUD.Migrations
{
    /// <inheritdoc />
    public partial class initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imgSouce",
                table: "Services",
                newName: "imgSource");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imgSource",
                table: "Services",
                newName: "imgSouce");
        }
    }
}
