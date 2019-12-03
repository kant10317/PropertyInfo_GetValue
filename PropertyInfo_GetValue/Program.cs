using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInfo_GetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet jupiter = new Planet("Jupiter", 3.65e08);
            GetPropertyValues(jupiter);

            Console.WriteLine("=====Custoemer Type=====");
            Customer customer = new Customer()
            {
                ID = 1,
                BirthDate = DateTime.Now,
                Gender = GenderCode.Male,
                Name = "Kant",
                Price = 1000000
            };

            linqGetProperties(customer);

            Console.ReadLine();
        }

        private static void linqGetProperties(Customer customer)
        {
            var pros = typeof(Customer).GetProperties().Cast<PropertyInfo>();
            foreach (var item in pros)
            {
                Console.WriteLine(String.Format("Type : {0} ,name : {1}, Value : {2}", item.PropertyType, item.Name, item.GetValue(customer, null)));
            }
        }

        private static void GetPropertyValues(Object obj)
        {
            Type t = obj.GetType();
            Console.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();
            Console.WriteLine("Properties (N = {0}):",
                              props.Length);
            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                      prop.PropertyType.Name,
                                      prop.GetValue(obj));
                else
                    Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                      prop.PropertyType.Name);

        }
    }
}
