namespace MentalHospital.DAL.Repositories;

public class PatientRepository(ApplicationDbContext context) : GenericRepository<Patient>(context), IPatientRepository
{

}