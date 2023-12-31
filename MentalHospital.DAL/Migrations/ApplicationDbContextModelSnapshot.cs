﻿// <auto-generated />
using System;
using MentalHospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MentalHospital.DAL.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AppointmentTime")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("RoomNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("ChamberNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<Guid?>("PersonalDoctorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Therapy")
                        .HasColumnType("text");

                    b.Property<DateTime>("UnregisteredAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PersonalDoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MentalHospital.DAL.Entities.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<DateTime>("SessionDateTime")
                        .HasColumnType("timestamp with time zone");

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
