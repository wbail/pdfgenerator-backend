using Microsoft.EntityFrameworkCore.Migrations;

namespace PdfGenerator.Migrations
{
    public partial class SeedBillingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into [Billings] (Title, [Description], Active, CreatedAt) values('Boleto', 'boleto', 1, SYSDATETIME());");
            migrationBuilder.Sql("insert into [Billings] (Title, [Description], Active, CreatedAt) values('Cartão de Crédito', 'crédito', 1, SYSDATETIME());");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}