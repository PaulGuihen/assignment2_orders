using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace orders.Models
{
     [Table("Employees")]
    public class Employees
    {
        [Key]

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
         //type for photo???
        public byte Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }
     public class EmployeesDBContext : DbContext
     {


         static EmployeesDBContext()
         {
             Database.SetInitializer<Models.EmployeesDBContext>(null);
         }



         public DbSet<Employees> EmployeesDbSet { get; set; }
     }
}