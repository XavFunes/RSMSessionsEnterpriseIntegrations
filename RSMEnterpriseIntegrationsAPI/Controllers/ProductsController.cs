using Microsoft.AspNetCore.Mvc;
using RSMEnterpriseIntegrationsAPI.Application.DTOs.ProductsDTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;

namespace RSMEnterpriseIntegrationsAPI.Controllers

{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService Service)
        {
            productService = Service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await productService.GetAll());
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await productService.GetProductsById(id));
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await productService.DeleteProduct(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateProductsDTO dto)
        {
            return Ok(await productService.CreateProduct(dto));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateProductsDTO dto)
        {
            return Ok(await productService.UpdateProduct(dto));
        }

    }
}
