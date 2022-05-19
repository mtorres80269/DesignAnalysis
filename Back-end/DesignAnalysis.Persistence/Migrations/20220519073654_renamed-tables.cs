using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignAnalysis.Persistence.Migrations
{
    public partial class renamedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "RolePage",
                newName: "RolePages");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Page",
                newName: "Pages");

            migrationBuilder.RenameTable(
                name: "Occupant",
                newName: "Occupants");

            migrationBuilder.RenameTable(
                name: "Floor",
                newName: "Floors");

            migrationBuilder.RenameTable(
                name: "Facility",
                newName: "Facilities");

            migrationBuilder.RenameTable(
                name: "BuildingFacility",
                newName: "BuildingFacilities");

            migrationBuilder.RenameTable(
                name: "Building",
                newName: "Buildings");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserId",
                table: "UserRoles",
                newName: "IxUserRolesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRoles",
                newName: "IxUserRolesRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolePage_RoleId",
                table: "RolePages",
                newName: "IxRolePagesRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolePage_PageId",
                table: "RolePages",
                newName: "IxRolePagesPageId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantProjectId",
                table: "Occupants",
                newName: "IxOccupantsProjectId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantFloorId",
                table: "Occupants",
                newName: "IxOccupantsFloorId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantFacilityId",
                table: "Occupants",
                newName: "IxOccupantsFacilityId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantBuildingId",
                table: "Occupants",
                newName: "IxOccupantsBuildingId");

            migrationBuilder.RenameIndex(
                name: "IxBuildingFacilityFacilityId",
                table: "BuildingFacilities",
                newName: "IxBuildingFacilitiesFacilityId");

            migrationBuilder.RenameIndex(
                name: "IxBuildingFacilityBuildingId",
                table: "BuildingFacilities",
                newName: "IxBuildingFacilitiesBuildingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "RolePages",
                newName: "RolePage");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "Page");

            migrationBuilder.RenameTable(
                name: "Occupants",
                newName: "Occupant");

            migrationBuilder.RenameTable(
                name: "Floors",
                newName: "Floor");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "Facility");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Building");

            migrationBuilder.RenameTable(
                name: "BuildingFacilities",
                newName: "BuildingFacility");

            migrationBuilder.RenameIndex(
                name: "IxUserRolesUserId",
                table: "UserRole",
                newName: "IX_UserRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IxUserRolesRoleId",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IxRolePagesRoleId",
                table: "RolePage",
                newName: "IX_RolePage_RoleId");

            migrationBuilder.RenameIndex(
                name: "IxRolePagesPageId",
                table: "RolePage",
                newName: "IX_RolePage_PageId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantsProjectId",
                table: "Occupant",
                newName: "IxOccupantProjectId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantsFloorId",
                table: "Occupant",
                newName: "IxOccupantFloorId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantsFacilityId",
                table: "Occupant",
                newName: "IxOccupantFacilityId");

            migrationBuilder.RenameIndex(
                name: "IxOccupantsBuildingId",
                table: "Occupant",
                newName: "IxOccupantBuildingId");

            migrationBuilder.RenameIndex(
                name: "IxBuildingFacilitiesFacilityId",
                table: "BuildingFacility",
                newName: "IxBuildingFacilityFacilityId");

            migrationBuilder.RenameIndex(
                name: "IxBuildingFacilitiesBuildingId",
                table: "BuildingFacility",
                newName: "IxBuildingFacilityBuildingId");
        }
    }
}
