using BlazorWebApp.Domain.Common;

namespace BlazorWebApp.Domain.Entities
{
    public class Employee : BaseAuditableEntity
    {
        public required string EmployeeCode { get; set; }
        public required string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Email { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string? JobType { get; set; }
        public string? Status { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}