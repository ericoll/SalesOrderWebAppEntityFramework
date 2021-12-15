using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesOrderWebApp.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public Products Product { get; set; }
        public decimal Price { get; set; }



        public SalesOrder()
        {
                
        }
    }

    public enum Products
    {
        Laptop,
        Keyboard,
        Paper
    }
}
