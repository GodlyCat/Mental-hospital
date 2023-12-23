namespace MentalHospital.API.ViewModels;

public class DoctorViewModel
{
	public Guid Id { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? AppointmentTime { get; set; }

	public int? RoomNumber { get; set; }

	public List<PatientViewModel> PersonalPatients { get; set; } = new();

	public List<SessionViewModel> Sessions { get; set; } = new();
}