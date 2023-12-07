namespace MentalHospital.BLL.Tests.Data.Models;

internal static class PatientModelData
{
	public static PatientModel InitPatientModel()
	{
		var patient = new PatientModel()
		{
			Id = Guid.NewGuid(),
			FirstName = "Tom",
			ChamberNumber = 1,
			RegisteredAt = DateTime.Now
		};

		return patient;
	}

	public static List<PatientModel> InitPatientCollection() 
	{ 
		return new List<PatientModel>() { InitPatientModel() }; 
	}
}