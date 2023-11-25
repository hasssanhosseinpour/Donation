﻿// <auto-generated />
using System;
using DonationModel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DonationModel.Data.Migrations
{
    [DbContext(typeof(DonationContext))]
    [Migration("20231121194957_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Contact", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("TEXT")
                        .HasAnnotation("RegEx", "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            AccountNo = 1,
                            City = "Richmond",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 17, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8266),
                            CreatedBy = "f@f.f",
                            Email = "sam@fox.com",
                            FirstName = "Sam",
                            LastName = "Fox",
                            Modified = new DateTime(2023, 11, 17, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8275),
                            ModifiedBy = "f@f.f",
                            PostalCode = "V4F 1M7",
                            Street = "457 Fox Avenue"
                        },
                        new
                        {
                            AccountNo = 2,
                            City = "Delta",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 18, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8279),
                            CreatedBy = "f@f.f",
                            Email = "ann@day.com",
                            FirstName = "Ann",
                            LastName = "Day",
                            Modified = new DateTime(2023, 11, 18, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8280),
                            ModifiedBy = "f@f.f",
                            PostalCode = "V6G 1M6",
                            Street = "231 River Road"
                        },
                        new
                        {
                            AccountNo = 3,
                            City = "Anytown",
                            Country = "USA",
                            Created = new DateTime(2023, 11, 19, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8282),
                            CreatedBy = "a@a.a",
                            Email = "john@doe.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2023, 11, 19, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8283),
                            ModifiedBy = "a@a.a",
                            PostalCode = "12345",
                            Street = "123 Main St"
                        },
                        new
                        {
                            AccountNo = 4,
                            City = "Another Town",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 20, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8286),
                            CreatedBy = "f@f.f",
                            Email = "jane@smith.ca",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modified = new DateTime(2023, 11, 20, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8287),
                            ModifiedBy = "f@f.f",
                            PostalCode = "67890",
                            Street = "456 Oak St"
                        },
                        new
                        {
                            AccountNo = 5,
                            City = "Coquitlam",
                            Country = "Canada",
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8290),
                            CreatedBy = "f@f.f",
                            Email = "tim@hick.ca",
                            FirstName = "Tim",
                            LastName = "Hick",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8290),
                            ModifiedBy = "f@f.f",
                            PostalCode = "V3A0E1",
                            Street = "456 Dayanee St"
                        });
                });

            modelBuilder.Entity("DonationModel.Model.Donation", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransId");

                    b.HasIndex("AccountNo");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 1,
                            Amount = 100f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8545),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8541),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8545),
                            ModifiedBy = "f@f.f",
                            Notes = "General donation",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 2,
                            Amount = 50f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8548),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8546),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8548),
                            ModifiedBy = "f@f.f",
                            Notes = "Monthly contribution",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 3,
                            Amount = 200f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8556),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8549),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8556),
                            ModifiedBy = "f@f.f",
                            Notes = "Yearly contribution",
                            PaymentMethodId = 3,
                            TransactionTypeId = 3
                        },
                        new
                        {
                            TransId = 4,
                            AccountNo = 1,
                            Amount = 50f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8559),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8558),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8559),
                            ModifiedBy = "f@f.f",
                            Notes = "Monthly contribution",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 5,
                            AccountNo = 1,
                            Amount = 50f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8561),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8560),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8561),
                            ModifiedBy = "f@f.f",
                            Notes = "Monthly contribution",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 6,
                            AccountNo = 1,
                            Amount = 50f,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8564),
                            CreatedBy = "f@f.f",
                            Date = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8562),
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8564),
                            ModifiedBy = "f@f.f",
                            Notes = "Monthly contribution",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        });
                });

            modelBuilder.Entity("DonationModel.Model.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8493),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8494),
                            ModifiedBy = "a@a.a",
                            Name = "Direct Deposit"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8495),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8496),
                            ModifiedBy = "a@a.a",
                            Name = "PayPal"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8497),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8497),
                            ModifiedBy = "a@a.a",
                            Name = "Check"
                        });
                });

            modelBuilder.Entity("DonationModel.Model.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8343),
                            CreatedBy = "a@a.a",
                            Description = "Donations made without any special purpose",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8344),
                            ModifiedBy = "a@a.a",
                            Name = "General Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8345),
                            CreatedBy = "a@a.a",
                            Description = "Donations made for homeless people",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8346),
                            ModifiedBy = "a@a.a",
                            Name = "Food for homeless"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8347),
                            CreatedBy = "a@a.a",
                            Description = "Donations for the purpose of upgrading the gym",
                            Modified = new DateTime(2023, 11, 21, 19, 49, 57, 681, DateTimeKind.Utc).AddTicks(8348),
                            ModifiedBy = "a@a.a",
                            Name = "Repair of Gym"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fa0b27b3-536b-495d-ae84-b689ca074274",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEMdMfe375vi702Zprs6JWBBRDWnrJNgvYsCyCbEd18GHG9onVZ2xhzg1XidOrUBTDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d8bf4bf9-5160-49b7-867b-d9248b05a51b",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEMAPny3CCOVzrDGrZbOU9xKzs8TrygXpScYSNKthoJIPIKYkcbhU9lQ6t87FC2tjRg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "f@f.f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DonationModel.Model.Donation", b =>
                {
                    b.HasOne("Contact", "Contact")
                        .WithMany("Donations")
                        .HasForeignKey("AccountNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DonationModel.Model.PaymentMethod", "PaymentMethod")
                        .WithMany("Donations")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DonationModel.Model.TransactionType", "TransactionType")
                        .WithMany("Donations")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("PaymentMethod");

                    b.Navigation("TransactionType");
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

            modelBuilder.Entity("Contact", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("DonationModel.Model.PaymentMethod", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("DonationModel.Model.TransactionType", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
