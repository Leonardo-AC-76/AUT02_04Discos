﻿// <auto-generated />
using System;
using AUT02_04Discos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AUT02_04Discos.Migrations
{
    [DbContext(typeof(ChinookContext))]
    [Migration("20230224160236_primera")]
    partial class primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AUT02_04Discos.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("AlbumId");

                    b.HasIndex(new[] { "ArtistId" }, "IFK_AlbumArtistId");

                    b.ToTable("Album", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("AUT02_04Discos.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("AUT02_04Discos.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("Bytes")
                        .HasColumnType("int");

                    b.Property<string>("Composer")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Milliseconds")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("TrackId");

                    b.HasIndex(new[] { "AlbumId" }, "IFK_TrackAlbumId");

                    b.HasIndex(new[] { "GenreId" }, "IFK_TrackGenreId");

                    b.HasIndex(new[] { "MediaTypeId" }, "IFK_TrackMediaTypeId");

                    b.ToTable("Track", null, t => t.ExcludeFromMigrations());
                });

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
                            Id = "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc",
                            ConcurrencyStamp = "b18dfb4c-1a8d-4e7e-b53f-a1d21ee6de1a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ea505525-2540-46be-b05e-553449721468",
                            ConcurrencyStamp = "066abaa9-d71b-4905-a0c6-42559c777652",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "9ff18fb8-6653-4d0f-a90f-fde1803dfe19",
                            ConcurrencyStamp = "69b46926-66ef-4b16-8f7b-bf58be0c89b5",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            Id = "257fe082-1a46-481a-aa43-303ca1a042cf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "293f86d2-f742-4275-985a-745246e2dcba",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAxO8b0gKO82EJN+LSG+2gjhtfOoDrbHhrEm4OqPV4fdrNJnS+Jdc22jrZUmhZFa0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "30390d39-5f4a-4f44-9a67-c690442b83b5",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "433e82a2-de09-47f6-95d6-968aca5f6901",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "43b15414-a1a9-44c0-bfd7-d2dc38da32b3",
                            Email = "manager@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@GMAIL.COM",
                            NormalizedUserName = "MANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENdPDB1k6qhW3n0oXOAHoYkZe3hVWUjJeRKYFTxiBpefZk1SoU1iebDaKXeikd5JTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73c571ac-7e37-481d-9cce-e9be9a7c813c",
                            TwoFactorEnabled = false,
                            UserName = "manager@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                            UserId = "257fe082-1a46-481a-aa43-303ca1a042cf",
                            RoleId = "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc"
                        },
                        new
                        {
                            UserId = "433e82a2-de09-47f6-95d6-968aca5f6901",
                            RoleId = "ea505525-2540-46be-b05e-553449721468"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AUT02_04Discos.Models.Album", b =>
                {
                    b.HasOne("AUT02_04Discos.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK_AlbumArtistId");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("AUT02_04Discos.Models.Track", b =>
                {
                    b.HasOne("AUT02_04Discos.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("FK_TrackAlbumId");

                    b.Navigation("Album");
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

            modelBuilder.Entity("AUT02_04Discos.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("AUT02_04Discos.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
