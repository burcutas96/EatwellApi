﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20250409190003_RemovePhoneFromUsers")]
    partial class RemovePhoneFromUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.BaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2025, 4, 9, 22, 0, 3, 647, DateTimeKind.Local).AddTicks(157));

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Entities.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Entities.Concrete.BranchEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchEmployees");
                });

            modelBuilder.Entity("Entities.Concrete.BranchImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchImages");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Adana"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Adıyaman"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Afyonkarahisar"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Ağrı"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            Name = "Amasya"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 1,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            Name = "Antalya"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 1,
                            Name = "Artvin"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 1,
                            Name = "Aydın"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 1,
                            Name = "Balıkesir"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 1,
                            Name = "Bilecik"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 1,
                            Name = "Bingöl"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 1,
                            Name = "Bitlis"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 1,
                            Name = "Bolu"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 1,
                            Name = "Burdur"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 1,
                            Name = "Bursa"
                        },
                        new
                        {
                            Id = 17,
                            CountryId = 1,
                            Name = "Çanakkale"
                        },
                        new
                        {
                            Id = 18,
                            CountryId = 1,
                            Name = "Çankırı"
                        },
                        new
                        {
                            Id = 19,
                            CountryId = 1,
                            Name = "Çorum"
                        },
                        new
                        {
                            Id = 20,
                            CountryId = 1,
                            Name = "Denizli"
                        },
                        new
                        {
                            Id = 21,
                            CountryId = 1,
                            Name = "Diyarbakır"
                        },
                        new
                        {
                            Id = 22,
                            CountryId = 1,
                            Name = "Edirne"
                        },
                        new
                        {
                            Id = 23,
                            CountryId = 1,
                            Name = "Elazığ"
                        },
                        new
                        {
                            Id = 24,
                            CountryId = 1,
                            Name = "Erzincan"
                        },
                        new
                        {
                            Id = 25,
                            CountryId = 1,
                            Name = "Erzurum"
                        },
                        new
                        {
                            Id = 26,
                            CountryId = 1,
                            Name = "Eskişehir"
                        },
                        new
                        {
                            Id = 27,
                            CountryId = 1,
                            Name = "Gaziantep"
                        },
                        new
                        {
                            Id = 28,
                            CountryId = 1,
                            Name = "Giresun"
                        },
                        new
                        {
                            Id = 29,
                            CountryId = 1,
                            Name = "Gümüşhane"
                        },
                        new
                        {
                            Id = 30,
                            CountryId = 1,
                            Name = "Hakkari"
                        },
                        new
                        {
                            Id = 31,
                            CountryId = 1,
                            Name = "Hatay"
                        },
                        new
                        {
                            Id = 32,
                            CountryId = 1,
                            Name = "Isparta"
                        },
                        new
                        {
                            Id = 33,
                            CountryId = 1,
                            Name = "Mersin"
                        },
                        new
                        {
                            Id = 34,
                            CountryId = 1,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 35,
                            CountryId = 1,
                            Name = "İzmir"
                        },
                        new
                        {
                            Id = 36,
                            CountryId = 1,
                            Name = "Kars"
                        },
                        new
                        {
                            Id = 37,
                            CountryId = 1,
                            Name = "Kastamonu"
                        },
                        new
                        {
                            Id = 38,
                            CountryId = 1,
                            Name = "Kayseri"
                        },
                        new
                        {
                            Id = 39,
                            CountryId = 1,
                            Name = "Kırklareli"
                        },
                        new
                        {
                            Id = 40,
                            CountryId = 1,
                            Name = "Kırşehir"
                        },
                        new
                        {
                            Id = 41,
                            CountryId = 1,
                            Name = "Kocaeli"
                        },
                        new
                        {
                            Id = 42,
                            CountryId = 1,
                            Name = "Konya"
                        },
                        new
                        {
                            Id = 43,
                            CountryId = 1,
                            Name = "Kütahya"
                        },
                        new
                        {
                            Id = 44,
                            CountryId = 1,
                            Name = "Malatya"
                        },
                        new
                        {
                            Id = 45,
                            CountryId = 1,
                            Name = "Manisa"
                        },
                        new
                        {
                            Id = 46,
                            CountryId = 1,
                            Name = "Kahramanmaraş"
                        },
                        new
                        {
                            Id = 47,
                            CountryId = 1,
                            Name = "Mardin"
                        },
                        new
                        {
                            Id = 48,
                            CountryId = 1,
                            Name = "Muğla"
                        },
                        new
                        {
                            Id = 49,
                            CountryId = 1,
                            Name = "Muş"
                        },
                        new
                        {
                            Id = 50,
                            CountryId = 1,
                            Name = "Nevşehir"
                        },
                        new
                        {
                            Id = 51,
                            CountryId = 1,
                            Name = "Niğde"
                        },
                        new
                        {
                            Id = 52,
                            CountryId = 1,
                            Name = "Ordu"
                        },
                        new
                        {
                            Id = 53,
                            CountryId = 1,
                            Name = "Rize"
                        },
                        new
                        {
                            Id = 54,
                            CountryId = 1,
                            Name = "Sakarya"
                        },
                        new
                        {
                            Id = 55,
                            CountryId = 1,
                            Name = "Samsun"
                        },
                        new
                        {
                            Id = 56,
                            CountryId = 1,
                            Name = "Siirt"
                        },
                        new
                        {
                            Id = 57,
                            CountryId = 1,
                            Name = "Sinop"
                        },
                        new
                        {
                            Id = 58,
                            CountryId = 1,
                            Name = "Sivas"
                        },
                        new
                        {
                            Id = 59,
                            CountryId = 1,
                            Name = "Tekirdağ"
                        },
                        new
                        {
                            Id = 60,
                            CountryId = 1,
                            Name = "Tokat"
                        },
                        new
                        {
                            Id = 61,
                            CountryId = 1,
                            Name = "Trabzon"
                        },
                        new
                        {
                            Id = 62,
                            CountryId = 1,
                            Name = "Tunceli"
                        },
                        new
                        {
                            Id = 63,
                            CountryId = 1,
                            Name = "Şanlıurfa"
                        },
                        new
                        {
                            Id = 64,
                            CountryId = 1,
                            Name = "Uşak"
                        },
                        new
                        {
                            Id = 65,
                            CountryId = 1,
                            Name = "Van"
                        },
                        new
                        {
                            Id = 66,
                            CountryId = 1,
                            Name = "Yozgat"
                        },
                        new
                        {
                            Id = 67,
                            CountryId = 1,
                            Name = "Zonguldak"
                        },
                        new
                        {
                            Id = 68,
                            CountryId = 1,
                            Name = "Aksaray"
                        },
                        new
                        {
                            Id = 69,
                            CountryId = 1,
                            Name = "Bayburt"
                        },
                        new
                        {
                            Id = 70,
                            CountryId = 1,
                            Name = "Karaman"
                        },
                        new
                        {
                            Id = 71,
                            CountryId = 1,
                            Name = "Kırıkkale"
                        },
                        new
                        {
                            Id = 72,
                            CountryId = 1,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = 73,
                            CountryId = 1,
                            Name = "Şırnak"
                        },
                        new
                        {
                            Id = 74,
                            CountryId = 1,
                            Name = "Bartın"
                        },
                        new
                        {
                            Id = 75,
                            CountryId = 1,
                            Name = "Ardahan"
                        },
                        new
                        {
                            Id = 76,
                            CountryId = 1,
                            Name = "Iğdır"
                        },
                        new
                        {
                            Id = 77,
                            CountryId = 1,
                            Name = "Yalova"
                        },
                        new
                        {
                            Id = 78,
                            CountryId = 1,
                            Name = "Karabük"
                        },
                        new
                        {
                            Id = 79,
                            CountryId = 1,
                            Name = "Kilis"
                        },
                        new
                        {
                            Id = 80,
                            CountryId = 1,
                            Name = "Osmaniye"
                        },
                        new
                        {
                            Id = 81,
                            CountryId = 1,
                            Name = "Düzce"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Türkiye"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("Entities.Concrete.MealCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MealCategories");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kullanıcı"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MealCategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MealCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BranchId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonCount")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReservationTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.HasBaseType("Entities.Concrete.BaseEntity");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.Branch", b =>
                {
                    b.HasOne("Entities.Concrete.City", "City")
                        .WithMany("Branches")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Entities.Concrete.BranchEmployee", b =>
                {
                    b.HasOne("Entities.Concrete.Branch", "Branch")
                        .WithMany("BranchEmployees")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entities.Concrete.BranchImage", b =>
                {
                    b.HasOne("Entities.Concrete.Branch", "Branch")
                        .WithMany("BranchImages")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.Evaluation", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Evaluations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.MealCategory", "MealCategory")
                        .WithMany("Products")
                        .HasForeignKey("MealCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealCategory");
                });

            modelBuilder.Entity("Entities.Concrete.Reservation", b =>
                {
                    b.HasOne("Entities.Concrete.Branch", "Branch")
                        .WithMany("Reservations")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Branch", b =>
                {
                    b.Navigation("BranchEmployees");

                    b.Navigation("BranchImages");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.MealCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Evaluations");

                    b.Navigation("UserOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
