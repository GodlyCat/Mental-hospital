namespace MentalHospital.DAL.Entities;

public class Doctor
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public List<DoctorPatient> DoctorPatients { get; set; } = new();

	public List<Patient> Patients { get; set; } = new();
}