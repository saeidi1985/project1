using Project1.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1.Models
{
    internal class Customer : BaseEntity
    {

        public string persianBirthDate
        {
            get
            {
                string PersianD = Creationdate.ToString("yyyy/mm/dd", new CultureInfo("fa-IR"));
                return PersianD;

            }
            
        }

        public DateTime BirthDate { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emaill { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsValidPhoneNumber { get; set; }
        public bool IsValidEmaill { get; set; }
        
        

    }
}
