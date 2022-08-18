using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Category cat = new Category();
            cat.Id = 1000;
            cat.Name = "Mike";

            Console.WriteLine(cat.Id);
            Console.WriteLine(cat.Name);

            Product product1 = new Product("", "", 10, 2000.00);
            int discount = 0;
            int min, max;

            string result = product1.UpdateDiscount(ref discount, out min, out max);
            Console.WriteLine(result);
            Console.WriteLine("Discount for the product = {0}", discount);
            Console.WriteLine("Min price range ={0}\n Max price range ={1}", min, max);

            Customer customerObj = new Customer("1000", "Barney");
            customerObj.AddContactDetails("barney@gmail.com", 9878987654, 8788787877, 9876546758);

            Console.WriteLine("Customer contact details are:\n");
            Console.WriteLine("Email ID = " + customerObj.EmailID);
            Console.WriteLine();

            foreach (long customerno in customerObj.CustomerContact)
            {
                Console.WriteLine("Contact Number = " + customerno);
            }
        }
    }
}
