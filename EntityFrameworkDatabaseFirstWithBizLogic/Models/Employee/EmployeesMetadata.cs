﻿using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDatabaseFirstWithBizLogic.Models
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
}