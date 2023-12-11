using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollabCRUD.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Pick_Services_ServiceId",
                table: "Pick");

            migrationBuilder.DropForeignKey(
                name: "FK_Pick_Users_UserId",
                table: "Pick");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pick",
                table: "Pick");

            migrationBuilder.DropColumn(
                name: "CustID",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Pick",
                newName: "Picks");

            migrationBuilder.RenameIndex(
                name: "IX_Pick_UserId",
                table: "Picks",
                newName: "IX_Picks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Pick_ServiceId",
                table: "Picks",
                newName: "IX_Picks_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picks",
                table: "Picks",
                column: "PickId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Picks_Services_ServiceId",
                table: "Picks",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Picks_Users_UserId",
                table: "Picks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Picks_Services_ServiceId",
                table: "Picks");

            migrationBuilder.DropForeignKey(
                name: "FK_Picks_Users_UserId",
                table: "Picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picks",
                table: "Picks");

            migrationBuilder.RenameTable(
                name: "Picks",
                newName: "Pick");

            migrationBuilder.RenameIndex(
                name: "IX_Picks_UserId",
                table: "Pick",
                newName: "IX_Pick_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Picks_ServiceId",
                table: "Pick",
                newName: "IX_Pick_ServiceId");

            migrationBuilder.AddColumn<int>(
                name: "CustID",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pick",
                table: "Pick",
                column: "PickId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pick_Services_ServiceId",
                table: "Pick",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pick_Users_UserId",
                table: "Pick",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
