namespace RSMEnterpriseIntegrationsAPI.Application.DTOs.CategoryDTOs
{
    public class GetCategoryDto
    {
        public short ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
