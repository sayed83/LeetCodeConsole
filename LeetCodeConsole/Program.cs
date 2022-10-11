using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeConsole
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //var second = Calculation.HowManySeconds(2);
            //var str = Calculation.smallerNum("12", "21");
            //Calculation.Addition(0);
            Console.WriteLine(Calculation.CalculateExponent(5,5));
            //Calculation cal = new Calculation();
            //Calculation.lessThan100(32, 45);
            //Customer[] customer = new Customer[3];
            //customer[0] = new Customer { Name = "Sayed", Gender = GenderType.Male };
            //customer[1] = new Customer { Name = "Saad", Gender = GenderType.Male };
            //customer[2] = new Customer { Name = "sanjida", Gender = GenderType.Female };

            //int[] values = (int[]) Enum.GetValues(typeof(GenderType));
            //string[] names = Enum.GetNames(typeof(GenderType));

            //foreach (var item in customer)
            //{

            //    Console.WriteLine("Name = {0} & Gender = {1}",item.Name,item.Gender);
            //}

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);

            //}
            //foreach (var n in names)
            //{
            //    Console.WriteLine(n);

            //}

            //try
            //{
            //    StreamReader reader = new StreamReader(@"D:\Inventory_Error1.txt");
            //    Console.WriteLine(reader.ReadToEnd());
            //    reader.Close();
            //}
            //catch (Exception ex)
            //{
            //    string path = @"D:\testerror.txt";
            //    StreamWriter writer = new StreamWriter(path);
            //    writer.Write(ex.GetType().Name);
            //    Console.WriteLine();
            //    writer.Write(ex.Message);
            //    writer.Close();
            //    Console.WriteLine(ex.Message);
            //}


            //Tutorial tutorial = new Tutorial();

            //List<Employee> emplist = new List<Employee>();
            //emplist.Add(new Employee() { Id=1, Name = "Sagor ", Salary = 37000, Experience = 6, PromotPeriod = 3 });
            //emplist.Add(new Employee() { Id=2, Name = "rashed ", Salary = 40000, Experience = 9, PromotPeriod = 2 });
            //emplist.Add(new Employee() { Id=3, Name = "Sayed ", Salary = 27000, Experience = 4, PromotPeriod = 3 });
            //emplist.Add(new Employee() { Id=4, Name = "Himo ", Salary = 28000, Experience = 4, PromotPeriod = 4 });
            //emplist.Add(new Employee() { Id=5, Name = "Parvag ", Salary = 15000, Experience = 1, PromotPeriod = 5 });

            //IsPromotable isPromotable = new IsPromotable(Employee.Promote);

            //Employee.PromoteEmployee(emplist,isPromotable);
            //Employee.PromoteEmployee(emplist,emp => emp.Experience >= emp.PromotPeriod);


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
            
            //var result = convertion.RomanToInt("IXL");
            //var result = convertion.IntToRoman1(Convert.ToInt32(input));

            //int[] nums = { 2, 7, 11, 15 };
            //int[] nums = { 3,3 };
            //int[] nums = { 3,2,4 };
            //var target = 9;
            //var target = 6;
            //var result = cal.TwoSum(nums, target);
            //Console.WriteLine(result);
        }


    }


    public enum GenderType
    {
        Male = 1,
        Female = 2,
        Other = 3
    }
}
