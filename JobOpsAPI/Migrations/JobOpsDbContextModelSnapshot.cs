﻿// <auto-generated />
using System;
using JobOpsAPI.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobOpsAPI.Migrations
{
    [DbContext(typeof(JobOpsDbContext))]
    partial class JobOpsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.JobTitle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Machine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Section", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.SectionEmployee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId", "SectionId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionEmployees");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Employee", b =>
                {
                    b.HasOne("JobOpsAPI.Domain.Entities.JobTitle", "JobTitle")
                        .WithMany("Employees")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Machine", b =>
                {
                    b.HasOne("JobOpsAPI.Domain.Entities.Section", "Section")
                        .WithMany("Machines")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Section");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Section", b =>
                {
                    b.HasOne("JobOpsAPI.Domain.Entities.Department", "Department")
                        .WithMany("Sections")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.SectionEmployee", b =>
                {
                    b.HasOne("JobOpsAPI.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobOpsAPI.Domain.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Department", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.JobTitle", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("JobOpsAPI.Domain.Entities.Section", b =>
                {
                    b.Navigation("Machines");
                });
#pragma warning restore 612, 618
        }
    }
}
