﻿// <auto-generated />
using System;
using MentalHospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MentalHospital.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MentalHospital.DAL.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppointmentTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ChamberNumber")
                        .HasColumnType("int");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PersonalDoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Therapy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UnregisteredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonalDoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SessionDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Patient", b =>
                {
                    b.HasOne("MentalHospital.DAL.Entities.Doctor", "PersonalDoctor")
                        .WithMany("PersonalPatients")
                        .HasForeignKey("PersonalDoctorId");

                    b.Navigation("PersonalDoctor");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Session", b =>
                {
                    b.HasOne("MentalHospital.DAL.Entities.Doctor", "Doctor")
                        .WithMany("Sessions")
                        .HasForeignKey("DoctorId");

                    b.HasOne("MentalHospital.DAL.Entities.Patient", "Patient")
                        .WithMany("Sessions")
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Doctor", b =>
                {
                    b.Navigation("PersonalPatients");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Patient", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}