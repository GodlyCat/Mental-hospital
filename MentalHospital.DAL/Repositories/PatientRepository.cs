using MentalHospital.DAL.Interfaces;
using MentalHospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentalHospital.DAL.Repositories
{
    public class PatientRepository : IRepository<Patient>
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Patient> Create(Patient entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _context.Patients.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Patient> Delete(string id)
        {
            var entity = _context.Patients.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                _context.Patients.Remove(entity);
                await _context.SaveChangesAsync();
            }

            return entity;
        }

        public async Task<Patient> Get(string id)
        {
            var entity = await _context.Patients.FirstOrDefaultAsync(p => p.Id == id);
            return entity;
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> Update(Patient entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
