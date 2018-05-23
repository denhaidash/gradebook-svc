﻿// <auto-generated />
using GradeBook.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GradeBook.DAL.Migrations
{
    [DbContext(typeof(GradebookContext))]
    [Migration("20180523184458_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("GradeBook.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(20);

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("PasswordSalt")
                        .IsRequired();

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("GradeBook.Models.AssestmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("AssestmentTypes");
                });

            modelBuilder.Entity("GradeBook.Models.FinalGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("GradebookRefId");

                    b.Property<int>("StudentRefId");

                    b.Property<int>("TeacherRefId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("StudentRefId");

                    b.HasIndex("TeacherRefId");

                    b.HasIndex("GradebookRefId", "StudentRefId")
                        .IsUnique();

                    b.ToTable("FinalGrades");
                });

            modelBuilder.Entity("GradeBook.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("GradebookRefId");

                    b.Property<int>("StudentRefId");

                    b.Property<int>("TeacherRefId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("GradebookRefId");

                    b.HasIndex("StudentRefId");

                    b.HasIndex("TeacherRefId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("GradeBook.Models.Gradebook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SemesterRefId");

                    b.Property<int>("SubjectRefId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectRefId");

                    b.HasIndex("SemesterRefId", "SubjectRefId")
                        .IsUnique();

                    b.ToTable("Gradebooks");
                });

            modelBuilder.Entity("GradeBook.Models.GradebookTeacher", b =>
                {
                    b.Property<int>("GradebookRefId");

                    b.Property<int>("TeacherRefId");

                    b.HasKey("GradebookRefId", "TeacherRefId");

                    b.HasIndex("TeacherRefId");

                    b.HasIndex("GradebookRefId", "TeacherRefId")
                        .IsUnique();

                    b.ToTable("GradebooksTeachers");
                });

            modelBuilder.Entity("GradeBook.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("SpecialityRefId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("SpecialityRefId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("GradeBook.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseNumber");

                    b.Property<DateTime>("EndsAt");

                    b.Property<int>("GroupRefId");

                    b.Property<int>("SemesterNumber");

                    b.Property<DateTime>("StartsAt");

                    b.HasKey("Id");

                    b.HasIndex("GroupRefId", "CourseNumber", "SemesterNumber")
                        .IsUnique();

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("GradeBook.Models.SemesterSubject", b =>
                {
                    b.Property<int>("SemesterRefId");

                    b.Property<int>("SubjectRefId");

                    b.Property<int>("AssestmentTypeRefId");

                    b.HasKey("SemesterRefId", "SubjectRefId");

                    b.HasIndex("AssestmentTypeRefId");

                    b.HasIndex("SubjectRefId");

                    b.HasIndex("SemesterRefId", "SubjectRefId")
                        .IsUnique();

                    b.ToTable("SemestersSubjects");
                });

            modelBuilder.Entity("GradeBook.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("GradeBook.Models.Student", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("GroupRefId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("GroupRefId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GradeBook.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("GradeBook.Models.Teacher", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("GradeBook.Models.FinalGrade", b =>
                {
                    b.HasOne("GradeBook.Models.Gradebook", "Gradebook")
                        .WithMany("FinalGrades")
                        .HasForeignKey("GradebookRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Student", "Student")
                        .WithMany("FinalGrades")
                        .HasForeignKey("StudentRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Teacher", "Teacher")
                        .WithMany("FinalGrades")
                        .HasForeignKey("TeacherRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Grade", b =>
                {
                    b.HasOne("GradeBook.Models.Gradebook", "Gradebook")
                        .WithMany("Grades")
                        .HasForeignKey("GradebookRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Teacher", "Teacher")
                        .WithMany("Grades")
                        .HasForeignKey("TeacherRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Gradebook", b =>
                {
                    b.HasOne("GradeBook.Models.Semester", "Semester")
                        .WithMany("Gradebooks")
                        .HasForeignKey("SemesterRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Subject", "Subject")
                        .WithMany("Gradebooks")
                        .HasForeignKey("SubjectRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.SemesterSubject", "SemesterSubject")
                        .WithOne("Gradebook")
                        .HasForeignKey("GradeBook.Models.Gradebook", "SemesterRefId", "SubjectRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.GradebookTeacher", b =>
                {
                    b.HasOne("GradeBook.Models.Gradebook", "Gradebook")
                        .WithMany("GradebookTeachers")
                        .HasForeignKey("GradebookRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Teacher", "Teacher")
                        .WithMany("GradebookTeachers")
                        .HasForeignKey("TeacherRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Group", b =>
                {
                    b.HasOne("GradeBook.Models.Specialty", "Speciality")
                        .WithMany("Groups")
                        .HasForeignKey("SpecialityRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Semester", b =>
                {
                    b.HasOne("GradeBook.Models.Group", "Group")
                        .WithMany("Semesters")
                        .HasForeignKey("GroupRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GradeBook.Models.SemesterSubject", b =>
                {
                    b.HasOne("GradeBook.Models.AssestmentType", "AssestmentType")
                        .WithMany("Semesters")
                        .HasForeignKey("AssestmentTypeRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Semester", "Semester")
                        .WithMany("SemesterSubjects")
                        .HasForeignKey("SemesterRefId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GradeBook.Models.Subject", "Subject")
                        .WithMany("Semesters")
                        .HasForeignKey("SubjectRefId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Student", b =>
                {
                    b.HasOne("GradeBook.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupRefId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GradeBook.Models.Account", "Account")
                        .WithOne("Student")
                        .HasForeignKey("GradeBook.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GradeBook.Models.Teacher", b =>
                {
                    b.HasOne("GradeBook.Models.Account", "Account")
                        .WithOne("Teacher")
                        .HasForeignKey("GradeBook.Models.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
