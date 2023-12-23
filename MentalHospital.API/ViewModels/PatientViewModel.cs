namespace MentalHospital.API.ViewModels;

public class PatientViewModel
{
	public Guid Id { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? Diagnosis { get; set; }

	public string? Therapy { get; set; }

	public int? ChamberNumber { get; set; }

	public DateTime RegisteredAt { get; set; }

	public DateTime UnregisteredAt { get; set; }

	public Guid? PersonalDoctorId { get; set; }

	public DoctorViewModel? PersonalDoctor { get; set; }

	public List<SessionViewModel> Sessions { get; set; } = new();
}