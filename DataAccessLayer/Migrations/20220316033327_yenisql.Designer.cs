﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220316033327_yenisql")]
    partial class yenisql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.AltyapıIsler", b =>
                {
                    b.Property<int>("lowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FınıshDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IhaleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IhaleDökuman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IhaleNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LocationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectDökuman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectPersonPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("lowerId");

                    b.HasIndex("CompanyId");

                    b.ToTable("AltyapıIslers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BalanceSmall", b =>
                {
                    b.Property<int>("BalanceSmallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Island")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parcel")
                        .HasColumnType("int");

                    b.Property<int>("SmallVehicleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TahakkukMiktarı")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VehicleNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("miktar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BalanceSmallId");

                    b.HasIndex("SmallVehicleId");

                    b.ToTable("BalanceSmalls");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTaxOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentTip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TexNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Complaint", b =>
                {
                    b.Property<int>("ComplaintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complainant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplainantPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conclusion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("lookperson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComplaintId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Filling", b =>
                {
                    b.Property<int>("FillingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FınıshDıstrıct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FınıshIsland")
                        .HasColumnType("int");

                    b.Property<int>("FınıshParcel")
                        .HasColumnType("int");

                    b.Property<string>("Nereden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereye")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartIsland")
                        .HasColumnType("int");

                    b.Property<int>("StartParcel")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TalepEden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vehicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleNumber")
                        .HasColumnType("int");

                    b.Property<string>("mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FillingId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Fillings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OtherStructure", b =>
                {
                    b.Property<int>("OtherStructureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FınıshDıstrıct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FınıshIsland")
                        .HasColumnType("int");

                    b.Property<string>("Nereden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereye")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartIsland")
                        .HasColumnType("int");

                    b.Property<int>("StartParcel")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TalepEden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vehicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleNumber")
                        .HasColumnType("int");

                    b.Property<string>("mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OtherStructureId");

                    b.HasIndex("CompanyId");

                    b.ToTable("OtherStructures");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Punishment", b =>
                {
                    b.Property<int>("CezaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AracVehicleId")
                        .HasColumnType("int");

                    b.Property<decimal>("CezaAmont")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CezaDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CezaPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CezaTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CezaId");

                    b.HasIndex("AracVehicleId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Punishments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SmallVehicle", b =>
                {
                    b.Property<int>("SmallVehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallVehicleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SmallVehicleId");

                    b.ToTable("SmallVehicles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Structure", b =>
                {
                    b.Property<int>("StructureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Atıkcinsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blok")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Casting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmptyExcavation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Excavation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcavationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Island")
                        .HasColumnType("int");

                    b.Property<string>("Mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OnayDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Parcel")
                        .HasColumnType("int");

                    b.Property<string>("PermitNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehiclePlaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ÜreticiAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ÜreticiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ÜreticiPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StructureId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Structures");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PersonStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PersonSurName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("DoumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("VehicleBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleDara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleHGS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleIMEI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleIzinBitis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehiclePlaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleTip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AltyapıIsler", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("AltyapıIslers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BalanceSmall", b =>
                {
                    b.HasOne("EntityLayer.Concrete.SmallVehicle", "SmallVehicle")
                        .WithMany("BalanceSmalls")
                        .HasForeignKey("SmallVehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SmallVehicle");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Complaint", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Complaints")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Filling", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Fillings")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OtherStructure", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("OtherStructures")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Punishment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Vehicle", "Arac")
                        .WithMany("Punishments")
                        .HasForeignKey("AracVehicleId");

                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Punishments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arac");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Structure", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Structures")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Vehicle", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Aracs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Company", b =>
                {
                    b.Navigation("AltyapıIslers");

                    b.Navigation("Aracs");

                    b.Navigation("Complaints");

                    b.Navigation("Fillings");

                    b.Navigation("OtherStructures");

                    b.Navigation("Punishments");

                    b.Navigation("Structures");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SmallVehicle", b =>
                {
                    b.Navigation("BalanceSmalls");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Vehicle", b =>
                {
                    b.Navigation("Punishments");
                });
#pragma warning restore 612, 618
        }
    }
}
