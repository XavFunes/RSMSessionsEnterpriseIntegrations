using RSMEnterpriseIntegrationsAPI.Application.DTOs.ProductsDTOs;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface IProductService
    {
        Task<GetProductsDTO?> GetProductsById(int id);
        Task<IEnumerable<GetProductsDTO>> GetAll();
        Task<int> CreateProduct(CreateProductsDTO productDto);
        Task<int> UpdateProduct(UpdateProductsDTO productDto);
        Task<int> DeleteProduct(int id);
    }
}
