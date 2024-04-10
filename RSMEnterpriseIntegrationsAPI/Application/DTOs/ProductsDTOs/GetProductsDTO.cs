namespace RSMEnterpriseIntegrationsAPI.Application.DTOs.ProductsDTOs
{
    public class GetProductsDTO
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? ProductNumber { get; set; }
        public int MakeFlag { get; set; }
        public int FinishedGoodsFlag { get; set; }
        public string? Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public string? Size { get; set; }
        public int DaysToManufacture { get; set; }
        public DateTime SellStartDate { get; set; } = DateTime.Now;
        public DateTime SellEndDate { get; set; }


    }
}
