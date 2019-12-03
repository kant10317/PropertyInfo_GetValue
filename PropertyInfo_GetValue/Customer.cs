using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInfo_GetValue
{
    public class Customer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Price { get; set; }

        public GenderCode Gender { get; set; }
    }

    public enum GenderCode
    {
        Male,
        Female
    }
}
