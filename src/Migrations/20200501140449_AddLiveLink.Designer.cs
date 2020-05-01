﻿// <auto-generated />
using System;
using BrekkeDanceCenter.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrekkeDanceCenter.Classes.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200501140449_AddLiveLink")]
    partial class AddLiveLink
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BrekkeDanceCenter.Classes.Entities.Class", b =>
                {
                    b.Property<long>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("YoutubeId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ClassId");

                    b.HasIndex("CourseId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BrekkeDanceCenter.Classes.Entities.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("LiveLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BrekkeDanceCenter.Classes.Entities.Class", b =>
                {
                    b.HasOne("BrekkeDanceCenter.Classes.Entities.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}