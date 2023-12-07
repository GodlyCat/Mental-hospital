namespace MentalHospital.BLL.Tests.Data.Entities;

internal static class PatientEntityData
{
	public static Patient InitPatientEntity()
	{
		var patient = new Patient()
		{
			Id = Guid.NewGuid(),
			FirstName = "Tom",
			ChamberNumber = 1,
			RegisteredAt = DateTime.Now
		};

		return patient;
	}

	public static List<Patient> InitPatientCollection()
	{
		return new List<Patient>() { InitPatientEntity() };
	}
}