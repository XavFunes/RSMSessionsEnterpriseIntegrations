namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;

    using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
    using RSMEnterpriseIntegrationsAPI.Domain.Models;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AdvWorksDbContext _context;
        public DepartmentRepository(AdvWorksDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateDepartment(Departament department)
        {
            await _context.AddAsync(department);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteDepartment(Departament department)
        {
            _context.Remove(department);

            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Departament>> GetAllDepartments()
        {
            return await _context.Set<Departament>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Departament?> GetDepartmentById(int id)
        {
            return await _context.Departments
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.DepartmentId == id);
        }

        public async Task<int> UpdateDepartment(Departament department)
        {
            _context.Update(department);

            return await _context.SaveChangesAsync();
        }
    }
}
