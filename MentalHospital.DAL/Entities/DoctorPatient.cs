namespace MentalHospital.DAL.Entities;

public class DoctorPatient
{
	public int Id { get; set; }

	public int DoctorId { get; set; }

	public Doctor? Doctor { get; set; }

	public int PatientId { get; set; }

	public Patient? Patient { get; set; }
}