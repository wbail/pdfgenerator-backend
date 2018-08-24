using Microsoft.EntityFrameworkCore.Migrations;

namespace PdfGenerator.Migrations
{
    public partial class SeedPermissionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into [Permissions] (Title, [Description], Active, CreatedAt) values('Admin', 'Root user', 1, SYSDATETIME());");
            migrationBuilder.Sql("insert into [Permissions] (Title, [Description], Active, CreatedAt) values('Customer', 'Customer user', 1, SYSDATETIME());");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}