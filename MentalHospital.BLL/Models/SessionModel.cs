namespace MentalHospital.BLL.Models;

public class SessionModel
{
	public Guid Id { get; set; }

	public Guid? DoctorId { get; set; }

	public DoctorModel? Doctor { get; set; }

	public Guid? PatientId { get; set; }

	public PatientModel? Patient { get; set; }

	public DateTime SessionDateTime { get; set; }

	public string? Result { get; set; }
}