using Microsoft.EntityFrameworkCore.Migrations;

namespace new_mvc.Migrations
{
    public partial class AddEmployeeTodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeesTbl",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TelePhone = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesTbl", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesTbl");
        }
    }
}
