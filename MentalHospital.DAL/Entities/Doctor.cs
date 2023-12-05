namespace MentalHospital.DAL.Entities;

public class Doctor
{
	public string Id { get; set; }

	public string? Name { get; set; }

	public string? Department { get; set; }

	public List<DoctorPatient> DoctorPatients { get; set; } = new();

	public List<Patient> Patients { get; set; } = new();
}