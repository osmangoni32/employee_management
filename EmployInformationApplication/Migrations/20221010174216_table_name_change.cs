using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployInformationApplication.Migrations
{
    /// <inheritdoc />
    public partial class tablenamechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployDatabaseModelInDatabase",
                table: "EmployDatabaseModelInDatabase");

            migrationBuilder.RenameTable(
                name: "EmployDatabaseModelInDatabase",
                newName: "EmployDatabaseModelInDatabaseAsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployDatabaseModelInDatabaseAsTable",
                table: "EmployDatabaseModelInDatabaseAsTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployDatabaseModelInDatabaseAsTable",
                table: "EmployDatabaseModelInDatabaseAsTable");

            migrationBuilder.RenameTable(
                name: "EmployDatabaseModelInDatabaseAsTable",
                newName: "EmployDatabaseModelInDatabase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployDatabaseModelInDatabase",
                table: "EmployDatabaseModelInDatabase",
                column: "Id");
        }
    }
}
