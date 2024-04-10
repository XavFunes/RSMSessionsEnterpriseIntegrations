namespace RSMEnterpriseIntegrationsAPI.Application.DTOs.ProductsDTOs
{
    public class UpdateProductsDTO
    {
        public int ProductId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? ProductNumber { get; set; } = string.Empty;
        public int MakeFlag { get; set; }
        public int FinishedGoodsFlag { get; set; }
        public string? Color { get; set; } = string.Empty;
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public string? Size { get; set; } = string.Empty;
        public int DaysToManufacture { get; set; }
    }
}
