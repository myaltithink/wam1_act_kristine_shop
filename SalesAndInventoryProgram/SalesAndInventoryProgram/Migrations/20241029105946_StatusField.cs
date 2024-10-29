using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesAndInventoryProgram.Migrations
{
    /// <inheritdoc />
    public partial class StatusField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Active");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");
        }
    }
}
