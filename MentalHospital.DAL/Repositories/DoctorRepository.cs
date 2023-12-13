namespace MentalHospital.DAL.Repositories;

public class DoctorRepository(ApplicationDbContext context) : GenericRepository<Doctor>(context), IDoctorRepository
{
}