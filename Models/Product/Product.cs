using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models.Product
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

    }
}
