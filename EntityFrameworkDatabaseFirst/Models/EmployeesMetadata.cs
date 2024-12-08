using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDatabaseFirst.Models
{
    public class EmployeesMetadata
    {
        [Required]
        [StringLength(20)]
        public string LastName;
        [Required]
        [StringLength(10)]
        public string FirstName;
    }

    [MetadataType(typeof(EmployeesMetadata))]
    public partial class Employees
    {
    }
}