using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace orders.Models
{
    [Table("Orders")]
    public class Orders
    {

        [Key]

        public String CustomerID { get; set; }
        public int EmployeeID{ get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public Decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }

    public class OrdersDBContext : DbContext
    {


        static OrdersDBContext()
        {
            Database.SetInitializer<Models.OrdersDBContext>(null);
        }



        public DbSet<Orders> OrdersDbSet { get; set; }
    }
}