﻿namespace MentalHospital.BLL.Models
{
    public class PatientModel
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Diagnosis { get; set; }
        public string? Therapy { get; set; }
        public int ChamberNumber { get; set; }
        public DateTime RegistredAt { get; set; }
        public DateTime DeregistredAt { get; set; }

        public string? PersonalDoctor { get; set; }
        public int? PersonalDoctorId { get; set; }
    }
}