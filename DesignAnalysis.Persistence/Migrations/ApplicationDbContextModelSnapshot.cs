﻿// <auto-generated />
using System;
using DesignAnalysis.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesignAnalysis.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<long?>("EngineerDetailId")
                        .HasColumnName("EngineerDetailId")
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

                    b.Property<string>("Revision")
                        .HasColumnName("Revision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stage")
                        .HasColumnName("Stage")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("int");

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
                        .IsUnique()
                        .HasName("IxProjectsCompanyId");

                    b.HasIndex("EngineerDetailId")
                        .HasName("IxProjectsEngineerDetailId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DesignAnalysis.Core.Entities.Project", b =>
                {
                    b.HasOne("DesignAnalysis.Core.Entities.Company", "Company")
                        .WithOne("Project")
                        .HasForeignKey("DesignAnalysis.Core.Entities.Project", "CompanyId")
                        .HasConstraintName("FK_Project_Company")
                        .IsRequired();

                    b.HasOne("DesignAnalysis.Core.Entities.EngineerDetail", "EngineerDetail")
                        .WithMany()
                        .HasForeignKey("EngineerDetailId")
                        .HasConstraintName("FkProjectsEngineerDetailsEngineerDetailId");
                });
#pragma warning restore 612, 618
        }
    }
}
