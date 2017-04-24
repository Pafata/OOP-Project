using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiKumSlujiteli
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public static int Counter { get; private set; }
        public void Show()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Last name : {0}", LastName);
            Console.WriteLine("Phone number : {0}", Phone);
            Console.WriteLine("--------------------------------------------");
            Counter++;
        }
        
    }
}
