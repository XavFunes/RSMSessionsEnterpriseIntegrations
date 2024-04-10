

using RSMEnterpriseIntegrationsAPI.Application.DTOs.CategoryDTOs;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface ICategoryService
    {

        Task<GetCategoryDto?>GetCategoryById(int id);
        Task<IEnumerable<GetCategoryDto>> GetAll();
        Task<int> CreateCategory(CreateCategoryDto category);
        Task<int> UpdateCategory(UpdateCategoryDto category);
        Task<int> DeleteCategory(int id);
    }
}
