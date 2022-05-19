using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignAnalysis.Persistence.Migrations
{
    public partial class addedProjectStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "ProjectStageId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjectStages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Stage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IxProjectsProjectStageId",
                table: "Projects",
                column: "ProjectStageId");

            migrationBuilder.CreateIndex(
                name: "IxProjectsProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectStage",
                table: "Projects",
                column: "ProjectStageId",
                principalTable: "ProjectStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectStatus",
                table: "Projects",
                column: "ProjectStatusId",
                principalTable: "ProjectStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectStage",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectStatus",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectStages");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropIndex(
                name: "IxProjectsProjectStageId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IxProjectsProjectStatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStageId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
