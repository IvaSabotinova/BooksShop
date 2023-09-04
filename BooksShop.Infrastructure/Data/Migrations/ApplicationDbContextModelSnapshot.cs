﻿// <auto-generated />
using System;
using BooksShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BooksShop.Infrastructure.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("nvarchar(26)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

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

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

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
                            Id = "283073f1-cc28-485a-ab58-44f4ed128264",
                            AccessFailedCount = 0,
                            Address = "Izgrev block 41, Bourgas 8000, Bulgaria",
                            ConcurrencyStamp = "71190574-dc75-4756-87dc-98d54c9c0122",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Iva",
                            LastName = "Sabotinova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEEqOux4peqG6cjDlXHk4ZnCGWJhDCpPmi1vlNZHHDWlOc1Yv+fWzXVguAleWRNNyqg==",
                            PhoneNumberConfirmed = false,
                            RegisteredOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5480),
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                            AccessFailedCount = 0,
                            Address = "Slaveykov block 33, Bourgas 8000, Bulgaria",
                            ConcurrencyStamp = "f7f6cb7d-0dd5-4bd2-9a3d-d6659b866057",
                            Email = "client@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Pesho",
                            LastName = "Martinov",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT@GMAIL.COM",
                            NormalizedUserName = "CLIENT",
                            PasswordHash = "AQAAAAEAACcQAAAAEKw5g63iBVKbJrRGZppQYH+mezVMZgcmoiOlBki9bal2lhqfELVbWP8aIrH/kRZGrg==",
                            PhoneNumberConfirmed = false,
                            RegisteredOn = new DateTime(2023, 9, 4, 23, 59, 12, 444, DateTimeKind.Local).AddTicks(7640),
                            TwoFactorEnabled = false,
                            UserName = "client"
                        });
                });

            modelBuilder.Entity("BooksShop.Infrastructure.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Bradley R. Schiller",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(4967),
                            ISBN = "007100940X",
                            ImageUrl = "/images/books/90e0e436-1c66-41ad-88e6-e1a153404144.jpg",
                            NumOfPages = 969,
                            Price = 25.8m,
                            Title = "The economy today"
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Stuart Mill",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5015),
                            ISBN = "OL25914464M",
                            ImageUrl = "/images/books/73174e87-d6b4-4604-9712-7330ab87ed72.jpg",
                            NumOfPages = 1013,
                            Price = 96.4m,
                            Title = "Principles of political economy"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Jose Rizal",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5018),
                            ISBN = "OL14042495M",
                            ImageUrl = "/images/books/b8422c70-aebe-4333-8908-0a59b53e9ab3.jpg",
                            NumOfPages = 502,
                            Price = 38.2m,
                            Title = "The social cancer"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Andrew S. Tanenbaum",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5020),
                            ISBN = "013162959X",
                            ImageUrl = "/images/books/0355b9fb-bf1b-4ae5-a3b9-a88ea551f1b5.jpg",
                            NumOfPages = 658,
                            Price = 99.9m,
                            Title = "Computer networks"
                        },
                        new
                        {
                            Id = 5,
                            Author = "June Jamrich Parsons and Dan Oja",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5023),
                            ISBN = "0760034397",
                            ImageUrl = "/images/books/e538ff43-dded-46c1-b7e9-f33cd2096314.jpg",
                            NumOfPages = 313,
                            Price = 75.0m,
                            Title = "Computer concepts"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Robert H. Blissmer",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5027),
                            ISBN = "0471617830",
                            ImageUrl = "/images/books/e5089e94-d32f-43f0-9c85-25b5ecdfcd2e.jpg",
                            NumOfPages = 445,
                            Price = 45.5m,
                            Title = "Introducing Computers"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Mario F. Triola",
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5030),
                            ISBN = "0805393277",
                            ImageUrl = "/images/books/04fe7e81-299e-4b26-b1fd-0e1a3149c9da.jpg",
                            NumOfPages = 581,
                            Price = 105.5m,
                            Title = "Elementary statistics"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Howard Anton",
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5033),
                            ISBN = "0471153060",
                            ImageUrl = "/images/books/005f0140-65ad-4b24-8f05-b2d45f274f49.jpg",
                            NumOfPages = 1130,
                            Price = 80.0m,
                            Title = "Calculus"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Silvanus Phillips Thompson",
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5035),
                            ISBN = "0312114109",
                            ImageUrl = "/images/books/8b457390-2df6-4f02-9a0b-6b3fe4890d85.jpg",
                            NumOfPages = 250,
                            Price = 75.5m,
                            Title = "Calculus made easy"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Soraya de Chadarevian and Harmke Kamminga",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5039),
                            ISBN = "9057022931",
                            ImageUrl = "/images/books/aa23bf8b-685c-430d-a256-7b684dd1cb90.jpg",
                            NumOfPages = 304,
                            Price = 99.0m,
                            Title = "Molecularizing biology and medicine"
                        },
                        new
                        {
                            Id = 11,
                            Author = "James A. Gillespie",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5042),
                            ISBN = "0521381835",
                            ImageUrl = "/images/books/27486390-9981-468b-93ad-c4cb1c8087ab.jpg",
                            NumOfPages = 358,
                            Price = 85.0m,
                            Title = "The price of health"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Pickering, George White Sir",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5045),
                            ISBN = "019519800X",
                            ImageUrl = "/images/books/3faa928e-f41d-4710-a469-b8b357eef1ba.jpg",
                            NumOfPages = 327,
                            Price = 60.0m,
                            Title = "Creative malady"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Richard G. Lipsey",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5047),
                            ISBN = "0060440163",
                            ImageUrl = "/images/books/fcc69c01-79fd-45b8-82cc-d7011b5493bc.jpg",
                            NumOfPages = 927,
                            Price = 98.5m,
                            Title = "Economics"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Adam Smith and Andrew Skinner",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5050),
                            ISBN = "067940564X",
                            ImageUrl = "/images/books/b449a8b1-84f1-44dd-8c6d-e965b6efa90b.jpg",
                            NumOfPages = 620,
                            Price = 68.5m,
                            Title = "The wealth of nations"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Hannah Arendt",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5053),
                            ISBN = "0226025926",
                            ImageUrl = "/images/books/3f3d222a-2401-437c-81b0-7db157cef7af.jpg",
                            NumOfPages = 365,
                            Price = 65.0m,
                            Title = "The human condition"
                        },
                        new
                        {
                            Id = 16,
                            Author = "Kenneth C. Laudon",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5055),
                            ISBN = "0072472618",
                            ImageUrl = "/images/books/3f569900-cc2e-4f9d-ac96-54cddcd7e4e6.jpg",
                            NumOfPages = 632,
                            Price = 62.0m,
                            Title = "The Interactive Computing"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Larry E. Long",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5058),
                            ISBN = "013156241X",
                            ImageUrl = "/images/books/22ec6be5-99cc-4e1b-91b8-0459f964cfdf.jpg",
                            NumOfPages = 677,
                            Price = 78.0m,
                            Title = "Computers"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Marshall C. Yovits",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5062),
                            ISBN = "012012114X",
                            ImageUrl = "/images/books/27cd64b2-01d7-4d33-bf31-ba2d9f5ef27a.jpg",
                            NumOfPages = 299,
                            Price = 69.0m,
                            Title = "Advances in Computers"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Angela Belli and John L. Coulehan",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5065),
                            ISBN = "0877456372",
                            ImageUrl = "/images/books/e194f5d1-1914-4ab7-ba69-f2c24cd46e03.jpg",
                            NumOfPages = 160,
                            Price = 69.9m,
                            Title = "Blood & bone"
                        },
                        new
                        {
                            Id = 20,
                            Author = "AnElissa Lucas",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5068),
                            ISBN = "0030594545",
                            ImageUrl = "/images/books/6dff32cc-dcbc-425a-8406-6463b36678df.jpg",
                            NumOfPages = 188,
                            Price = 35.0m,
                            Title = "Chinese medical modernization"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Richard Selzer",
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5070),
                            ISBN = "0312186878",
                            ImageUrl = "/images/books/3cc142ee-2ac0-4cee-8a63-d88d271d0c86.jpg",
                            NumOfPages = 389,
                            Price = 40.0m,
                            Title = "The doctor stories"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Elliott, Carl and John D. Lantos",
                            CategoryId = 5,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5073),
                            ISBN = "0822323362",
                            ImageUrl = "/images/books/3c0e44e3-4cb5-4c12-845e-5179e4b82717.jpg",
                            NumOfPages = 167,
                            Price = 52.9m,
                            Title = "The last physician"
                        },
                        new
                        {
                            Id = 23,
                            Author = "Aldous Huxley",
                            CategoryId = 5,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5076),
                            ISBN = "0060120355",
                            ImageUrl = "/images/books/86960c70-fd36-4ed1-94f9-3ecb8c47aa5a.jpg",
                            NumOfPages = 311,
                            Price = 30.0m,
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 24,
                            Author = "Battista Guarini",
                            CategoryId = 5,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5078),
                            ISBN = "OL17974570M",
                            ImageUrl = "/images/books/b977e8e1-30eb-44a8-b70b-88a87fb7bbe5.jpg",
                            NumOfPages = 262,
                            Price = 32.5m,
                            Title = "Il pastor fido"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Ernest F. Haeussler",
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5081),
                            ISBN = "0130338559",
                            ImageUrl = "/images/books/d31de0aa-e93a-4122-ae68-a894811f66d1.jpg",
                            NumOfPages = 822,
                            Price = 79.9m,
                            Title = "Introductory mathematical analysis"
                        },
                        new
                        {
                            Id = 26,
                            Author = "John G. Kemeny",
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5084),
                            ISBN = "013468835X",
                            ImageUrl = "/images/books/875ef8c0-31d5-476f-bd2c-0b1bd35aea0f.jpg",
                            NumOfPages = 465,
                            Price = 59.9m,
                            Title = "Introduction to finite mathematics"
                        },
                        new
                        {
                            Id = 27,
                            Author = "Adam Freeman",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5086),
                            ISBN = "OL5818599M",
                            ImageUrl = "/images/books/b907a2b2-c4f3-4233-aef4-a0c46098a6df.jpg",
                            NumOfPages = 264,
                            Price = 35.5m,
                            Title = "Pro ASP .NET Core 6"
                        });
                });

            modelBuilder.Entity("BooksShop.Infrastructure.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Economics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Technology"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Medicine"
                        },
                        new
                        {
                            Id = 5,
                            Name = "History"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("BooksShop.Infrastructure.Data.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(7000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(330)
                        .HasColumnType("nvarchar(330)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");
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
                            Id = "ec3a92cc-8b64-4b83-bc6a-c20031faa327",
                            ConcurrencyStamp = "6610b899-c6bf-4036-9831-ad602745c824",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "b1353077-7dcd-4f94-820b-f8af8feb9690",
                            ConcurrencyStamp = "b2e26a49-1cd2-47b3-ba2b-2211e7d851e6",
                            Name = "Client",
                            NormalizedName = "CLIENT"
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
                            UserId = "283073f1-cc28-485a-ab58-44f4ed128264",
                            RoleId = "ec3a92cc-8b64-4b83-bc6a-c20031faa327"
                        },
                        new
                        {
                            UserId = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                            RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690"
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

            modelBuilder.Entity("BooksShop.Infrastructure.Data.Book", b =>
                {
                    b.HasOne("BooksShop.Infrastructure.Data.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.HasOne("BooksShop.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BooksShop.Infrastructure.Data.ApplicationUser", null)
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

                    b.HasOne("BooksShop.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BooksShop.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BooksShop.Infrastructure.Data.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
