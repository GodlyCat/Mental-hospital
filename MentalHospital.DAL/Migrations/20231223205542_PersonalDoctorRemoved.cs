﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PersonalDoctorRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_PersonalDoctorId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PersonalDoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PersonalDoctorId",
                table: "Patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PersonalDoctorId",
                table: "Patients",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PersonalDoctorId",
                table: "Patients",
                column: "PersonalDoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_PersonalDoctorId",
                table: "Patients",
                column: "PersonalDoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
