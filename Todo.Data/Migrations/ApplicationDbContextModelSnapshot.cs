﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.Data;

#nullable disable

namespace Todo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "33B7ED72-9434-434A-82D4-3018B018CB87",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ee0f9af2-819f-4c3e-bdc9-1a1f05e01af9",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEInvhoJq7QVWnQt/5mSZfTZsCfUUGQfBYgbmjvB3peW9j31h1BeSmJTm9OJJzQQ57w==",
                            PhoneNumber = "555337681",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b918f78a-dea2-4735-a1a7-30f1665b747e",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00a7ce4d-fd28-40ec-9b59-1a238f66c4e8",
                            Email = "nika@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "NIKA@GMAIL.COM",
                            NormalizedUserName = "NIKA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEO6p6uPnS4cCjx59PY5YQK52pBHrAwQmicXDuvDfvgSaCunhYelzhJtZVw38pxinnA==",
                            PhoneNumber = "558490645",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "656239ca-5e5a-41df-964b-6d449e1e3e27",
                            TwoFactorEnabled = false,
                            UserName = "nika@gmail.com"
                        },
                        new
                        {
                            Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "87e35831-91a0-447f-b3c0-4d2590d4a0f6",
                            Email = "gio@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "GIO@GMAIL.COM",
                            NormalizedUserName = "GIO@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENojx0ISt3hUQJ6Yo9uY6QcsI3E3Oxf4t0r7WwoucBInnExL+vLIHQKxMbDVQbi4NA==",
                            PhoneNumber = "551442269",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dbf9d2a5-29df-4bd8-8364-3b328bcf64ec",
                            TwoFactorEnabled = false,
                            UserName = "gio@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87"
                        },
                        new
                        {
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        },
                        new
                        {
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Todo.Entities.TodoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descrtiption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descrtiption = "პირველი საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 10, 21, 38, 8, 102, DateTimeKind.Local).AddTicks(1079),
                            Priority = 2,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1074),
                            Status = 1,
                            Title = "პირველი საქმე",
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                        },
                        new
                        {
                            Id = 2,
                            Descrtiption = "მეორე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 10, 21, 38, 8, 102, DateTimeKind.Local).AddTicks(1089),
                            Priority = 1,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1088),
                            Status = 1,
                            Title = "მეორე საქმე",
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                        },
                        new
                        {
                            Id = 3,
                            Descrtiption = "მესამე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 11, 1, 38, 8, 102, DateTimeKind.Local).AddTicks(1092),
                            Priority = 4,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1091),
                            Status = 2,
                            Title = "მესამე საქმე",
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                        },
                        new
                        {
                            Id = 4,
                            Descrtiption = "მეოთხე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 17, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1094),
                            Priority = 1,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1094),
                            Status = 1,
                            Title = "მეოთხე საქმე",
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                        },
                        new
                        {
                            Id = 5,
                            Descrtiption = "მეხუთე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 13, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1099),
                            Priority = 3,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1099),
                            Status = 1,
                            Title = "მეხუთე საქმე",
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                        },
                        new
                        {
                            Id = 6,
                            Descrtiption = "მეექვსე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 20, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1102),
                            Priority = 2,
                            StartDate = new DateTime(2024, 5, 10, 20, 38, 8, 102, DateTimeKind.Local).AddTicks(1101),
                            Status = 2,
                            Title = "მეექვსე საქმე",
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Todo.Entities.TodoEntity", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });
#pragma warning restore 612, 618
        }
    }
}
