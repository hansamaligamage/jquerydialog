using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using studentmanagementsystem.Models;

namespace studentmanagementsystem.Migrations
{
    [DbContext(typeof(studentmanagementsystemContext))]
    [Migration("20170529081218_assignmentschange")]
    partial class assignmentschange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("studentmanagementsystem.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StudentId");

                    b.Property<string>("Subject");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("studentmanagementsystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("studentmanagementsystem.Models.Assignment", b =>
                {
                    b.HasOne("studentmanagementsystem.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
