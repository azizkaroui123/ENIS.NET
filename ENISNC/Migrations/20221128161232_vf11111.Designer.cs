﻿// <auto-generated />
using ENISNC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ENISNC.Migrations
{
    [DbContext(typeof(ENISContext))]
    [Migration("20221128161232_vf11111")]
    partial class vf11111
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ENISNC.Models.DemandePFE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("approved_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("demanded_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DemandePFE");
                });

            modelBuilder.Entity("ENISNC.Models.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("spacialitée")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departement");
                });

            modelBuilder.Entity("ENISNC.Models.Paper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Staus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("approved_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("demanded_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paper");
                });

            modelBuilder.Entity("ENISNC.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartementId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartementId");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("ENISNC.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sectionId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("sectionId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PaperUser", b =>
                {
                    b.Property<int>("papersId")
                        .HasColumnType("int");

                    b.Property<int>("usersUserId")
                        .HasColumnType("int");

                    b.HasKey("papersId", "usersUserId");

                    b.HasIndex("usersUserId");

                    b.ToTable("PaperUser");
                });

            modelBuilder.Entity("ENISNC.Models.DemandePFE", b =>
                {
                    b.HasOne("ENISNC.Models.User", "user")
                        .WithMany("demandePFE")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ENISNC.Models.Section", b =>
                {
                    b.HasOne("ENISNC.Models.Departement", "Departement")
                        .WithMany("sections")
                        .HasForeignKey("DepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departement");
                });

            modelBuilder.Entity("ENISNC.Models.User", b =>
                {
                    b.HasOne("ENISNC.Models.Section", "section")
                        .WithMany()
                        .HasForeignKey("sectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("section");
                });

            modelBuilder.Entity("PaperUser", b =>
                {
                    b.HasOne("ENISNC.Models.Paper", null)
                        .WithMany()
                        .HasForeignKey("papersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENISNC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("usersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ENISNC.Models.Departement", b =>
                {
                    b.Navigation("sections");
                });

            modelBuilder.Entity("ENISNC.Models.User", b =>
                {
                    b.Navigation("demandePFE");
                });
#pragma warning restore 612, 618
        }
    }
}
