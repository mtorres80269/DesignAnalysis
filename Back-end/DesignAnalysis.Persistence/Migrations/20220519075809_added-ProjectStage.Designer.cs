﻿// <auto-generated />
using System;
using DesignAnalysis.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesignAnalysis.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220519075809_added-ProjectStage")]
    partial class addedProjectStage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuildingName")
                        .HasColumnName("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Building");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.BuildingFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingId")
                        .HasColumnName("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnName("FacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Building_Facility");

                    b.HasIndex("BuildingId")
                        .HasName("IxBuildingFacilitiesBuildingId");

                    b.HasIndex("FacilityId")
                        .HasName("IxBuildingFacilitiesFacilityId");

                    b.ToTable("BuildingFacilities");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnName("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanySecondaryName")
                        .HasColumnName("CompanySecondaryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnName("CreatedById")
                        .HasColumnType("int");

                    b.Property<long>("CreatedUnixTime")
                        .HasColumnName("CreatedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DeletedBy")
                        .HasColumnName("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeletedById")
                        .HasColumnName("DeletedById")
                        .HasColumnType("int");

                    b.Property<long?>("DeletedUnixTime")
                        .HasColumnName("DeletedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnName("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("UpdatedById")
                        .HasColumnType("int");

                    b.Property<long?>("UpdatedUnixTime")
                        .HasColumnName("UpdatedUnixTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PK_Companies");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.EngineerDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnName("CreatedById")
                        .HasColumnType("int");

                    b.Property<long>("CreatedUnixTime")
                        .HasColumnName("CreatedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DeletedBy")
                        .HasColumnName("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeletedById")
                        .HasColumnName("DeletedById")
                        .HasColumnType("int");

                    b.Property<long?>("DeletedUnixTime")
                        .HasColumnName("DeletedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("IssueDate")
                        .HasColumnName("IssueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedAt")
                        .HasColumnName("IssuedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PtrNo")
                        .HasColumnName("PtrNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .HasColumnName("RegNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tin")
                        .HasColumnName("Tin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("UpdatedById")
                        .HasColumnType("int");

                    b.Property<long?>("UpdatedUnixTime")
                        .HasColumnName("UpdatedUnixTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PK_EngineerDetails");

                    b.ToTable("EngineerDetails");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area")
                        .HasColumnName("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calculation")
                        .HasColumnName("Calculation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityName")
                        .HasColumnName("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OccupantLoad")
                        .HasColumnName("OccupantLoad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitOfMeasurement")
                        .HasColumnName("UnitOfMeasurement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Facility");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FloorName")
                        .HasColumnName("FloorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Floor");

                    b.ToTable("Floors");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Occupant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingId")
                        .HasColumnName("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnName("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("FloorId")
                        .HasColumnName("FloorId")
                        .HasColumnType("int");

                    b.Property<int>("OccupantCount")
                        .HasColumnName("OccupantCount")
                        .HasColumnType("int");

                    b.Property<long>("ProjectId")
                        .HasColumnName("ProjectId")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PK_Occupant");

                    b.HasIndex("BuildingId")
                        .HasName("IxOccupantsBuildingId");

                    b.HasIndex("FacilityId")
                        .HasName("IxOccupantsFacilityId");

                    b.HasIndex("FloorId")
                        .HasName("IxOccupantsFloorId");

                    b.HasIndex("ProjectId")
                        .HasName("IxOccupantsProjectId");

                    b.ToTable("Occupants");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlName")
                        .HasColumnName("UrlName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Page");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientName")
                        .HasColumnName("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CompanyId")
                        .HasColumnName("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnName("CreatedById")
                        .HasColumnType("int");

                    b.Property<long>("CreatedUnixTime")
                        .HasColumnName("CreatedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DeletedBy")
                        .HasColumnName("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeletedById")
                        .HasColumnName("DeletedById")
                        .HasColumnType("int");

                    b.Property<long?>("DeletedUnixTime")
                        .HasColumnName("DeletedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<long>("EngineerDetailsId")
                        .HasColumnName("EngineerDetailsId")
                        .HasColumnType("bigint");

                    b.Property<string>("Location")
                        .HasColumnName("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnName("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectStageId")
                        .HasColumnName("ProjectStageId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectStatusId")
                        .HasColumnName("ProjectStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Revision")
                        .HasColumnName("Revision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemName")
                        .HasColumnName("SystemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("UpdatedById")
                        .HasColumnType("int");

                    b.Property<long?>("UpdatedUnixTime")
                        .HasColumnName("UpdatedUnixTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PK_Projects");

                    b.HasIndex("CompanyId")
                        .HasName("IxProjectsCompanyId");

                    b.HasIndex("EngineerDetailsId");

                    b.HasIndex("ProjectStageId")
                        .HasName("IxProjectsProjectStageId");

                    b.HasIndex("ProjectStatusId")
                        .HasName("IxProjectsProjectStatusId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.ProjectStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectStageName")
                        .HasColumnName("ProjectStageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Project_Stage");

                    b.ToTable("ProjectStages");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectStatusName")
                        .HasColumnName("ProjectStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Project_Status");

                    b.ToTable("ProjectStatus");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Role");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.RolePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PageId")
                        .HasColumnName("PageId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Role_Page");

                    b.HasIndex("PageId")
                        .HasName("IxRolePagesPageId");

                    b.HasIndex("RoleId")
                        .HasName("IxRolePagesRoleId");

                    b.ToTable("RolePages");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedUnixTime")
                        .HasColumnName("CreatedUnixTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnName("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnName("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedUnixTime")
                        .HasColumnName("UpdatedUnixTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PK_User");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_User_Role");

                    b.HasIndex("RoleId")
                        .HasName("IxUserRolesRoleId");

                    b.HasIndex("UserId")
                        .HasName("IxUserRolesUserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.BuildingFacility", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Building", "Building")
                        .WithMany("BuildingFacilities")
                        .HasForeignKey("BuildingId")
                        .HasConstraintName("FK_Building_Facility_Building")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.Facility", "Facility")
                        .WithMany("BuildingFacilities")
                        .HasForeignKey("FacilityId")
                        .HasConstraintName("FK_Building_Facility_Facility")
                        .IsRequired();
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Occupant", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Building", "Building")
                        .WithMany("Occupants")
                        .HasForeignKey("BuildingId")
                        .HasConstraintName("FK_Occupant_Building")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.Facility", "Facility")
                        .WithMany("Occupants")
                        .HasForeignKey("FacilityId")
                        .HasConstraintName("FK_Occupant_Facility")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.Floor", "Floor")
                        .WithMany("Occupants")
                        .HasForeignKey("FloorId")
                        .HasConstraintName("FK_Occupant_Floor")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.Project", "Project")
                        .WithMany("Occupants")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_Occupant_Project")
                        .IsRequired();
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Project", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Project_Company")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.EngineerDetail", "EngineerDetail")
                        .WithMany("Projects")
                        .HasForeignKey("EngineerDetailsId")
                        .HasConstraintName("FK_Project_EngineerDetail")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.ProjectStage", "ProjectStage")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectStageId")
                        .HasConstraintName("FK_Project_ProjectStage")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.ProjectStatus", "ProjectStatus")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectStatusId")
                        .HasConstraintName("FK_Project_ProjectStatus")
                        .IsRequired();
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.RolePage", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Page", "Page")
                        .WithMany("RolePages")
                        .HasForeignKey("PageId")
                        .HasConstraintName("FK_RolePage_Page")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.Role", "Role")
                        .WithMany("RolePages")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_RolePage_Role")
                        .IsRequired();
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.UserRole", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_UserRole_Role")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserRole_User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}