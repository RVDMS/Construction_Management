using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RVDMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixLocationPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BaseLongitude",
                table: "Users",
                type: "float(9)",
                precision: 9,
                scale: 6,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 15);

            migrationBuilder.AlterColumn<double>(
                name: "BaseLatitude",
                table: "Users",
                type: "float(9)",
                precision: 9,
                scale: 6,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 15);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BaseLongitude",
                table: "Users",
                type: "float(18)",
                precision: 18,
                scale: 15,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(9)",
                oldPrecision: 9,
                oldScale: 6);

            migrationBuilder.AlterColumn<double>(
                name: "BaseLatitude",
                table: "Users",
                type: "float(18)",
                precision: 18,
                scale: 15,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(9)",
                oldPrecision: 9,
                oldScale: 6);
        }
    }
}
