using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(200)]
        public string EmpName { get; set; } = String.Empty;
        [StringLength(10)]
        public string EmpCode { get; set; } = String.Empty;
        public int? EmployeeAge { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmpLocation { get; set; }
        public bool EmpActive { get; set; }

    }
}
