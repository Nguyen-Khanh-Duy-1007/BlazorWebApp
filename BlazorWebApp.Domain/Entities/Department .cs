using BlazorWebApp.Domain.Common;

namespace BlazorWebApp.Domain.Entities
{
    public class Department : BaseAuditableEntity
    {
        public required string DepartmentName { get; set; }
        public required string Location { get; set; }
        public DateTime EstablishedDate { get; set; }
        public string? Description { get; set; }
        public int? ManagerID { get; set; }
        public Employee? Manager { get; set; }
        ICollection<Employee>? Employees { get; set; }
    }
}