﻿namespace RSMEnterpriseIntegrationsAPI.Domain.Models
{
    public class Departament
    {
        public short DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? GroupName { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
