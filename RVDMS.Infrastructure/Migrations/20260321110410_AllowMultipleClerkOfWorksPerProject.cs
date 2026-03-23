using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RVDMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AllowMultipleClerkOfWorksPerProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectAssignments_ProjectId_Role",
                table: "ProjectAssignments");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAssignments_ProjectId_Role",
                table: "ProjectAssignments",
                columns: new[] { "ProjectId", "Role" },
                filter: "[RevokedAt] IS NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectAssignments_ProjectId_Role",
                table: "ProjectAssignments");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAssignments_ProjectId_Role",
                table: "ProjectAssignments",
                columns: new[] { "ProjectId", "Role" },
                unique: true,
                filter: "[Role] = 'COW' AND [RevokedAt] IS NULL");
        }
    }
}
