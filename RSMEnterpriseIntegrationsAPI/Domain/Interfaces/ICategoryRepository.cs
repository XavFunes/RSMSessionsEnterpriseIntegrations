using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetCategoryById(int id);
        Task<IEnumerable<Category>> GetAllCategory();
        Task<int> CreateCategory(Category category);
        Task<int> UpdateCategory(Category category);
        Task<int> DeleteCategory(Category category);
    }
}
