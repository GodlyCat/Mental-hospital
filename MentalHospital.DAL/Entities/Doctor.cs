namespace MentalHospital.DAL.Entities;

public class Doctor
{
	public Guid Id { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? AppointmentTime { get; set; }

	public int? RoomNumber { get; set; }

	public List<DoctorPatient> DoctorPatients { get; set; } = new();

	public List<Patient> Patients { get; set; } = new();
}