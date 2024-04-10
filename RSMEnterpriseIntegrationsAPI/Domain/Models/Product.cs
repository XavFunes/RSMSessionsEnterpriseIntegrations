namespace RSMEnterpriseIntegrationsAPI.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int MakeFlag { get; set; }
        public int FinishedGoodsFlag { get; set; }
        public string? Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public string? Size { get; set; }
        public string? SizeUnitMeasureCode { get; set; } = null;
        public string? WeightUnitMeasureCode { get; set; } = null;
        public decimal? Weight { get; set; } = null;
        public int DaysToManufacture { get; set; }
        public string? ProductLine { get; set; } = null;
        public string? Class { get; set; } = null;
        public string? Style { get; set; } = null;
        public int? ProductSubcategoryID { get; set; } = null;
        public int? ProductModelID { get; set; } = null;
        public DateTime SellStartDate { get; set; } = DateTime.Now;
        public DateTime SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; } = null;




    }
}
