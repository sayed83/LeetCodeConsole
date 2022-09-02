using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tutorial tutorial = new Tutorial();

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { Id=1, Name = "Sagor ", Salary = 37000, Experience = 6 });
            emplist.Add(new Employee() { Id=2, Name = "rashed ", Salary = 40000, Experience = 9 });
            emplist.Add(new Employee() { Id=3, Name = "Sayed ", Salary = 27000, Experience = 4 });
            emplist.Add(new Employee() { Id=4, Name = "Himo ", Salary = 28000, Experience = 4 });
            emplist.Add(new Employee() { Id=5, Name = "Parvag ", Salary = 15000, Experience = 1 });

            //IsPromotable isPromotable = new IsPromotable(Employee.Promote);

            //Employee.PromoteEmployee(emplist,isPromotable);
            Employee.PromoteEmployee(emplist,emp => emp.Experience >= 5);


            //HellowDelegate @del = new HellowDelegate(tutorial.Hello);
            //del("Hellow world");
            //tutorial.Hello("Hello Sayed");

            //Problem p = new Problem();
            //p.Genarate10RendomNumber();
            //p.Genarate10NumberGetMaxNumber();
            //p.Genarate3NumberFindBigger();
            // p.FindEvenOrOddNumber();
            //p.LowerBetweenTwoNumber();
            //p.CalculateTotalSalary();
            //p.ShowNumberInRange();
            //p.MaxArea();
            //int[] nums = { -1, 0, 1, 2, -1, -4 };
            //p.ThreeSum(nums);
            //p.ThreeSum1(nums);

            //p.GenarateRendomNumber(1, 100);
            // Console.WriteLine(result);

            //Problem p = new Problem();
            //int[] nums1 = { 1, 3};
            //int[] nums2 = { 2 };
            //var result = p.FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine(result);

            //PalindromeLinkedList pr = new PalindromeLinkedList();
            //ListNode list = new ListNode()
            //{

            //};        

            // Convertion convertion = new Convertion();
            //Calculation cal = new Calculation();
            //var result = convertion.RomanToInt("IXL");
            //var result = convertion.IntToRoman1(Convert.ToInt32(input));

            //int[] nums = { 2, 7, 11, 15 };
            //var target = 9;
            //var result = cal.TwoSum(nums, target);
            //Console.WriteLine(result);
        }


    }
}
