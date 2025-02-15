using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ask.NET.Migrations
{
    /// <inheritdoc />
    public partial class InvitesAndAskResponses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Asks",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "Asks");
        }
    }
}
