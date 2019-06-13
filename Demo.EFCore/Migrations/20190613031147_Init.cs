using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.EFCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "NETCORE");

            migrationBuilder.CreateTable(
                name: "STUDENT",
                schema: "NETCORE",
                columns: table => new
                {
                    USERID = table.Column<string>(nullable: false),
                    NAME = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENT", x => x.USERID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STUDENT",
                schema: "NETCORE");
        }
    }
}
