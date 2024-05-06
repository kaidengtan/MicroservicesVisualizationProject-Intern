using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HorizontalSwimLane.Migrations
{
    public partial class newLogTableInput : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "Protocol",
                table: "Services",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "ElapsedTime",
                table: "Services",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ActionName",
                table: "Services",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Services",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionName",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Protocol",
                keyValue: null,
                column: "Protocol",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Protocol",
                table: "Services",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ElapsedTime",
                keyValue: null,
                column: "ElapsedTime",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ElapsedTime",
                table: "Services",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
