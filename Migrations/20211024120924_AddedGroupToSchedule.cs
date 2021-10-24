using Microsoft.EntityFrameworkCore.Migrations;

namespace WebLearningProj.Migrations
{
    public partial class AddedGroupToSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Schedules",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Schedules");
        }
    }
}
