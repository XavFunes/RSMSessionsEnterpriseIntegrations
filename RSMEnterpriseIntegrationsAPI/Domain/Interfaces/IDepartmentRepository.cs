namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    using RSMEnterpriseIntegrationsAPI.Domain.Models;

    public interface IDepartmentRepository
    {
        Task<Departament?> GetDepartmentById(int id);
        Task<IEnumerable<Departament>> GetAllDepartments();
        Task<int> CreateDepartment(Departament department);
        Task<int> UpdateDepartment(Departament department);
        Task<int> DeleteDepartment(Departament department);
    }
}
