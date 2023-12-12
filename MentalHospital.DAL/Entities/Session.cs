namespace MentalHospital.DAL.Entities;

public class Session : Entity
{
	public Guid? DoctorId { get; set; }

	public Doctor? Doctor { get; set; }

	public Guid? PatientId { get; set; }

	public Patient? Patient { get; set; }

	public DateTime SessionDateTime { get; set; }

	public string? Result { get; set; }
}