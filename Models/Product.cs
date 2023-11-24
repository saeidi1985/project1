using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName {  get; set; }
        public decimal Price {  get; set; }
        public bool IsActive { get; set; }  
        public int count { get; set; }
        public DateTime Creationdate { get; set; }
    }
}
