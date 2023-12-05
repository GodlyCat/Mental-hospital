namespace MentalHospital.DAL.Entities;

public class DoctorPatient
{
	public Guid Id { get; set; }

	public string DoctorId { get; set; }

	public Doctor? Doctor { get; set; }

	public string PatientId { get; set; }

	public Patient? Patient { get; set; }
}