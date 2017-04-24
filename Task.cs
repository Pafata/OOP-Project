using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiKumSlujiteli
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Employeefortask { get; set; }
        public string Deadline { get; set; }
        
        public void Show()
        {
            Console.WriteLine("Title of the task : {0}", Title);
            Console.WriteLine("Description of the task : {0}", Description);
            Console.WriteLine("Employee for the task : {0}", Employeefortask);
            Console.WriteLine("Deadline : {0}", Deadline);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
