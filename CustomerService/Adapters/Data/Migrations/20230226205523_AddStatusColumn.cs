using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Customer",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "DocumentType",
                table: "Customer",
                newName: "DocumentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Customer",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeId",
                table: "Customer",
                newName: "DocumentType");
        }
    }
}
