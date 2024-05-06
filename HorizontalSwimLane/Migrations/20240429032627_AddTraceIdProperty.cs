using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HorizontalSwimLane.Migrations
{
    public partial class AddTraceIdProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TraceId",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraceId",
                table: "Services");
        }
    }
}
