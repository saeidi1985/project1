using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emaill { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsValidPhoneNumber { get; set; }
        public bool IsValidEmaill { get; set; }
        public bool IsActive { get; set; }
        public DateTime Creationdate { get; set; }

    }
}
