using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCart_ClientLayer.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_data_Carts_data_Users_UserId",
                table: "data_Carts");

            migrationBuilder.DropIndex(
                name: "IX_data_Carts_UserId",
                table: "data_Carts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "data_Carts");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "data_Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_data_Users_CartID",
                table: "data_Users",
                column: "CartID",
                unique: true,
                filter: "[CartID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_data_Users_data_Carts_CartID",
                table: "data_Users",
                column: "CartID",
                principalTable: "data_Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_data_Users_data_Carts_CartID",
                table: "data_Users");

            migrationBuilder.DropIndex(
                name: "IX_data_Users_CartID",
                table: "data_Users");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "data_Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "data_Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_data_Carts_UserId",
                table: "data_Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_data_Carts_data_Users_UserId",
                table: "data_Carts",
                column: "UserId",
                principalTable: "data_Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
