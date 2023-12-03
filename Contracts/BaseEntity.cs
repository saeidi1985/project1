using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Contracts
{
    internal class BaseEntity
    {
        public BaseEntity() 
        {
            IsActive = true;
            Creationdate = DateTime.Now;
            Random random = new Random();
            Id = random.Next(minValue: 1, maxValue: 1000);
        }
        public BaseEntity(bool isactive)
        {
            IsActive = isactive;
            Creationdate = DateTime.Now;
            Random random = new Random();
            Id = random.Next(minValue: 1, maxValue: 1000);
        }
        public BaseEntity(bool isactive,int minVlue,int maxValue)
        {
            IsActive = isactive;
            Creationdate = DateTime.Now;
            Random random = new Random();
            Id = random.Next(minValue: minVlue, maxValue: maxValue);
        }


        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime Creationdate { get; set; }
    }
}
