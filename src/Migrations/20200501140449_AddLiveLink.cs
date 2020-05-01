using Microsoft.EntityFrameworkCore.Migrations;

namespace BrekkeDanceCenter.Classes.Migrations
{
    public partial class AddLiveLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LiveLink",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LiveLink",
                table: "Courses");
        }
    }
}
