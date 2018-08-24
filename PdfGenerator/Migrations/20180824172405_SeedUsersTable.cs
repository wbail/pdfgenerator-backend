using Microsoft.EntityFrameworkCore.Migrations;

namespace PdfGenerator.Migrations
{
    public partial class SeedUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into [Users] (Active, CreatedAt, Name, Email, Password, PermissionId) values(1, sysdatetime(), 'Test Admin', 'admin@test.com', 'test123', 1);");
            migrationBuilder.Sql("insert into [Users] (Active, CreatedAt, Name, Email, Password, PermissionId) values(1, sysdatetime(), 'Test Customer', 'customer@test.com', 'test123', 2);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}