namespace RSMEnterpriseIntegrationsAPI.Domain.Models
{
    public class Category

    {
        public short ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
