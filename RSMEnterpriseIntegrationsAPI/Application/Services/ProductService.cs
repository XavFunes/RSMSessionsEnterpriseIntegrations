using RSMEnterpriseIntegrationsAPI.Application.DTOs.ProductsDTOs;
using RSMEnterpriseIntegrationsAPI.Application.Exceptions;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public async Task<int> CreateProduct(CreateProductsDTO productDto)
        {
            if (productDto is null
                || string.IsNullOrWhiteSpace(productDto.Name)
                || string.IsNullOrWhiteSpace(productDto.ProductNumber))
            {
                throw new BadRequestException("Product info not valid");
            }

            Product product = new()
            {
                ProductNumber = productDto.ProductNumber,
                Name = productDto.Name,
                MakeFlag = productDto.MakeFlag,
                FinishedGoodsFlag = productDto.FinishedGoodsFlag,
                Color = productDto.Color,
                SafetyStockLevel = productDto.SafetyStockLevel,
                ReorderPoint = productDto.ReorderPoint,
                StandardCost = productDto.StandardCost,
                ListPrice = productDto.ListPrice,
                Size = productDto.Size,
                DaysToManufacture = productDto.DaysToManufacture,
            };

            return await _productRepository.CreateProduct(product);
        }

        public async Task<int> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id is not valid.");
            }
            var product = await ValidateProductExistence(id);

            return await _productRepository.DeleteProduct(product);
        }

        public async Task<Product> ValidateProductExistence(int id)
        {
            var existengProduct = await _productRepository.GetProductsById(id)
                ?? throw new NotFoundException($"Departamente with Id: {id} was not found");
            return existengProduct;

        }

        public async Task<IEnumerable<GetProductsDTO>> GetAll()
        {
            var products = await _productRepository.GetAllProducts();
            List<GetProductsDTO> getProductsDTOs = [];

            foreach (var product in products)
            {
                GetProductsDTO dto = new()
                {
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    MakeFlag = product.MakeFlag,
                    FinishedGoodsFlag = product.FinishedGoodsFlag,
                    Color = product.Color,
                    SafetyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = product.StandardCost,
                    ListPrice = product.ListPrice,
                    Size = product.Size,
                    DaysToManufacture = product.DaysToManufacture,
                    SellStartDate = product.SellStartDate,
                    SellEndDate = product.SellEndDate,
                };

                getProductsDTOs.Add(dto);
            }

            return getProductsDTOs;
        }

        public async Task<GetProductsDTO?> GetProductsById(int id)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Product is not valid");
            }

            var product = await ValidateProductExistence(id);

            GetProductsDTO dto = new()
            {
                Name = product.Name,
                ProductNumber = product.ProductNumber,
                MakeFlag = product.MakeFlag,
                FinishedGoodsFlag = product.FinishedGoodsFlag,
                Color = product.Color,
                SafetyStockLevel = product.SafetyStockLevel,
                ReorderPoint = product.ReorderPoint,
                StandardCost = product.StandardCost,
                ListPrice = product.ListPrice,
                Size = product.Size,
                DaysToManufacture = product.DaysToManufacture,
                SellStartDate = product.SellStartDate,
                SellEndDate = product.SellEndDate,
            };

            return dto;

        }

        public async Task<int> UpdateProduct(UpdateProductsDTO productDto)
        {
            if (productDto is null)
            {
                throw new BadRequestException("Product info is not valid");
            }
            var product = await ValidateProductExistence(productDto.ProductId);

            product.Name = String.IsNullOrWhiteSpace(productDto.Name) ? product.Name : productDto.Name;
            product.ProductNumber = String.IsNullOrWhiteSpace(productDto.ProductNumber) ? product.ProductNumber : productDto.ProductNumber;

            return await _productRepository.UpdateProduct(product);
        }
    }
}
