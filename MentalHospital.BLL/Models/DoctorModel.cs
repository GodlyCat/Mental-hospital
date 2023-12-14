namespace MentalHospital.BLL.Models;

public class DoctorModel
{
	public Guid Id { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? AppointmentTime { get; set; }

	public int? RoomNumber { get; set; }

	public List<PatientModel> PersonalPatients { get; set; } = new();
}