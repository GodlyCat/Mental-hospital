namespace MentalHospital.DAL.Entities;

public class Doctor : Entity
{
	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? AppointmentTime { get; set; }

	public int? RoomNumber { get; set; }

	public List<Patient> PersonalPatients { get; set; } = new();

	public List<Session> Sessions { get; set; } = new();
}