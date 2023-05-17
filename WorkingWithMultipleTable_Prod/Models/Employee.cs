﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkingWithMultipleTable_Prod.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; } = default!;

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Gender { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DeparymentId")]
        public Department Department { get; set; }=default!;
    }
}
