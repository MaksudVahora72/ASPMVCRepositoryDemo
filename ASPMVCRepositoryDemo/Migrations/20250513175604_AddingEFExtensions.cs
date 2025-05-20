using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPMVCRepositoryDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddingEFExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EDept = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EJob = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EMobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Esal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
