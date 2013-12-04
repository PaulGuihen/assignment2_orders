using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace orders.Models
{
    public class Shippers
    {
        [Key]

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }

    public class ShippersDBContext : DbContext
    {
       

        static ShippersDBContext()
        {
            Database.SetInitializer<Models.ShippersDBContext>(null);
        }

        

        public DbSet<Shippers> ShippersDbSet { get; set; }
    }



}