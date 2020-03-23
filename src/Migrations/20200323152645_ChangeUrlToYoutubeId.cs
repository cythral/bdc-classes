using Microsoft.EntityFrameworkCore.Migrations;

namespace BrekkeDanceCenter.Classes.Migrations
{
    public partial class ChangeUrlToYoutubeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "YoutubeId",
                table: "Classes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoutubeId",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Classes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
