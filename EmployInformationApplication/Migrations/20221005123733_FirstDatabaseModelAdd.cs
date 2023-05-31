using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployInformationApplication.Migrations
{
    /// <inheritdoc />
    public partial class FirstDatabaseModelAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployDatabaseModelInDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departmaent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployDatabaseModelInDatabase", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployDatabaseModelInDatabase");
        }
    }
}
