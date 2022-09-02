 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HellowDelegate(string Message);


namespace LeetCodeConsole
{
    public class Tutorial
    {
        //A delegate is a type safe function pointer
        public void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

    public delegate bool IsPromotable(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable isElegibleToPromote)
        {
            foreach (Employee item in employees)
            {
                if(isElegibleToPromote(item))
                {
                    Console.WriteLine(item.Name + "Promoted"); 
                }
            }
        }

        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
