using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ask.NET.Migrations
{
    /// <inheritdoc />
    public partial class JoinUserOnAsk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "To",
                table: "Asks");

            migrationBuilder.AlterColumn<int>(
                name: "Visibility",
                table: "Asks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "ToId",
                table: "Asks",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asks_ToId",
                table: "Asks",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asks_Users_ToId",
                table: "Asks",
                column: "ToId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asks_Users_ToId",
                table: "Asks");

            migrationBuilder.DropIndex(
                name: "IX_Asks_ToId",
                table: "Asks");

            migrationBuilder.DropColumn(
                name: "ToId",
                table: "Asks");

            migrationBuilder.AlterColumn<string>(
                name: "Visibility",
                table: "Asks",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "Asks",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
