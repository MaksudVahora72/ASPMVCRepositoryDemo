using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPMVCRepositoryDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Employee name should not exceeds 50 characters")]
        [DisplayName("Employee Name")]
        public string EName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Department should not exceeds 20 characters")]
        [DisplayName("Department")]
        public string EDept { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Designation should not exceeds 30 characters")]
        [DisplayName("Designation")]
        public string EJob { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Mobile should not exceeds 50 characters")]
        [DisplayName("Contact Mobile")]
        public string EMobile { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Email should not exceeds 50 characters")]
        [DisplayName("Employee Email")]
        public string EEmail { get; set; }

        [Required]
        [Range(10000,300000)]
        [DisplayName("Salary")]
        public double Esal { get; set; }

    }
}
