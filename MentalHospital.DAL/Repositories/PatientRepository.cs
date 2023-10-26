using MentalHospital.DAL.interfaces;
using MentalHospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentalHospital.DAL.Repositories
{
    internal class PatientRepository : IRepository<Patient>
    {
        ApplicationDbContext _context;

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
            var targetEntity = _context.Patients.FirstOrDefault(p => p.Id == entity.Id);
            if (targetEntity != null)
            {
                targetEntity.Name = entity.Name;
                targetEntity.Diagnosis = entity.Diagnosis;
                targetEntity.ChamberNumber = entity.ChamberNumber;
                targetEntity.Therapy = entity.Therapy;
                targetEntity.PersonalDoctorId = entity.PersonalDoctorId;
                targetEntity.PersonalDoctor = entity.PersonalDoctor;
                targetEntity.RegistredAt = entity.RegistredAt;
                targetEntity.DeregistredAt = entity.DeregistredAt;

                await _context.SaveChangesAsync();
            }
            return entity;
        }
    }
}
