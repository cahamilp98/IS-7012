using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneonOneTest.Migrations
{
    /// <inheritdoc />
    public partial class AccountHolder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountHolderId",
                table: "AccountHolder",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountHolder",
                newName: "AccountHolderId");
        }
    }
}
