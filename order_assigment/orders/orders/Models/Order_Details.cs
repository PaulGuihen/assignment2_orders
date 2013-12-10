using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace orders.Models
{
    [Table("Order Details")]
    public class Order_Details
    {
       

    
         [Key]

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public Single Discount { get; set; }
    }

    public class Order_DetailsDBContext : DbContext
    {


        static Order_DetailsDBContext()
        {
            Database.SetInitializer<Models.Order_DetailsDBContext>(null);
        }



        public DbSet<Order_Details> Order_DetailsDbSet { get; set; }
    }

}