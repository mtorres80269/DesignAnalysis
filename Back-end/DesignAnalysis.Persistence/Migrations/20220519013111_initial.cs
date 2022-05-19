using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignAnalysis.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedUnixTime = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedUnixTime = table.Column<long>(nullable: true),
                    DeletedById = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedUnixTime = table.Column<long>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanySecondaryName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineerDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedUnixTime = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedUnixTime = table.Column<long>(nullable: true),
                    DeletedById = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedUnixTime = table.Column<long>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    RegNo = table.Column<string>(nullable: true),
                    PtrNo = table.Column<string>(nullable: true),
                    Tin = table.Column<string>(nullable: true),
                    IssueDate = table.Column<string>(nullable: true),
                    IssuedAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineerDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedUnixTime = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedUnixTime = table.Column<long>(nullable: true),
                    DeletedById = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedUnixTime = table.Column<long>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Revision = table.Column<string>(nullable: true),
                    Stage = table.Column<int>(nullable: false),
                    SystemName = table.Column<string>(nullable: true),
                    CompanyId = table.Column<long>(nullable: false),
                    EngineerDetailsId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Company",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_EngineerDetail",
                        column: x => x.EngineerDetailsId,
                        principalTable: "EngineerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IxProjectsCompanyId",
                table: "Projects",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_EngineerDetailsId",
                table: "Projects",
                column: "EngineerDetailsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "EngineerDetails");
        }
    }
}
