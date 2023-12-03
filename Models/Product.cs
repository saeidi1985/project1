using Project1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    internal class Product:BaseEntity
    {
        public Product()
        {
           
        }
        public Product(string name, String brandName, Decimal price)
        {
            Name = name;
            BrandName = brandName;
            Price = price;
            

        }

        public Product(string name, String brandName, Decimal price, int count) : base(false,1,1000)
        {
            Name = name;
            BrandName = brandName;  
            Price = price;
            Count = count;

        }
       
        public string Name { get; set; }
        public string BrandName {  get; set; }
        public decimal Price {  get; set; }
        public int Count { get; set; }
        
    }
}
