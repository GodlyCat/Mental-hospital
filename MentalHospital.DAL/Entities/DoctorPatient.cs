namespace MentalHospital.DAL.Entities;

public class DoctorPatient
{
	public string Id { get; set; }

	public string DoctorId { get; set; }

	public Doctor? Doctor { get; set; }

	public string PatientId { get; set; }

	public Patient? Patient { get; set; }
}