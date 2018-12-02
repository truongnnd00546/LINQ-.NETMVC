using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LINQ.NETMVC.Models;

namespace LINQ.NETMVC.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}