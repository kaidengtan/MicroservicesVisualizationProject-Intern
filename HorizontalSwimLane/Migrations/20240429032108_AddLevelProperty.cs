using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HorizontalSwimLane.Migrations
{
    public partial class AddLevelProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "ServiceName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Services",
                newName: "Level");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceName",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Services",
                newName: "Name");
        }
    }
}
