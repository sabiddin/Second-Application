using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Aplication.Business;

namespace Second_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business();
            Console.WriteLine(business.GetMessage());
            Console.Read();
        }
    }
}
