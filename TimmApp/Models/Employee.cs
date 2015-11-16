using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimmApp.Models
{
    public enum EmployedAs
    {
        [Display(Name = "Full time")]
        Fulltime,

        [Display(Name = "Part time")]
        Parttime,
        Hourly,
        Contractor

    }
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string Fname { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string Lname { get; set; }

        [Display(Name = "Phone number")]
        public int PhoneNum { get; set; }

        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

        [Display(Name = "Employed as")]
        public EmployedAs EmployedAs { get; set; }

        [Required]
        [Display(Name = "Contract sign date")]
        public DateTime ContractStartDate { get; set; }

        [Required]
        [Display(Name = "Contract ends")]
        public DateTime ContractEndDate { get; set; }
    }

    //public class EmployeeDbContext : DbContext
    //{
    //    public EmployeeDbContext() : base ("EmployeeDbContext")
    //    {

    //    }

    //    public DbSet<Employee> Employees { get; set; }
    //}
}