namespace MentalHospital.DAL.Entities;

public class Doctor
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public string? Department { get; set; }

	public List<DoctorPatient> DoctorPatients { get; set; } = new();
}