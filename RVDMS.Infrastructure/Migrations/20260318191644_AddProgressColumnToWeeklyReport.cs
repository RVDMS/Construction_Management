using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RVDMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProgressColumnToWeeklyReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Progress",
                table: "WeeklyReports",
                type: "decimal(5,3)",
                precision: 5,
                scale: 3,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progress",
                table: "WeeklyReports");
        }
    }
}
