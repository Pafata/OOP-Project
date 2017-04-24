using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiKumSlujiteli
{
    class Program
    {
        static void EnterEmploye(Employee employee)
        {
            Console.WriteLine("Въведете данни за служител:");
            Console.WriteLine("Име на служител:");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Презиме на служител");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Въведете телефонен номер на служител");
            employee.Phone = int.Parse(Console.ReadLine());
        }
        static void EnterTasks(Task task)
        {
            Console.WriteLine("Въведете данни за задача:");
            Console.Write("Заглавие на задача:");
            task.Title = Console.ReadLine();
            Console.WriteLine("Описание на задача:");
            task.Description = Console.ReadLine();
            Console.WriteLine("Въведете име на служител за задача:");
            task.Employeefortask = Console.ReadLine();
            Console.WriteLine("Въведете краен срок за задачата:");
            task.Deadline = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            EnterEmploye(employee1);

            Employee employee2 = new Employee();
            EnterEmploye(employee2);

            Task task1 = new Task();
            EnterTasks(task1);

            Task task2 = new Task();
            EnterTasks(task2);

            Console.WriteLine("Tasks :");
            Console.WriteLine("");

            task1.Show();
            task2.Show();

            Console.WriteLine("");
            Console.WriteLine("Employees :");
            Console.WriteLine("");

            employee1.Show();
            employee2.Show();

            Console.WriteLine("Брой служители : {0}",Employee.Counter);
        }
    }
}
