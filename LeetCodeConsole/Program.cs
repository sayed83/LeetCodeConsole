using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeConsole
{

    public class Program
    {
        public static int[] CountFrequencies(string[] words)
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");
            var freqMap = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (freqMap.ContainsKey(word))
                {
                    freqMap[word]++;
                }
                else
                {
                    freqMap.Add(word, 1);
                }
            }

            var result = new int[freqMap.Count];
            int i = 0;

            foreach (var kvp in freqMap)
            {
                result[i++] = kvp.Value;
            }

            return result;
        }
        public static int LuckyMoney(int money, int giftees)
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");
            for (int i = 0; money < 100; i++)
            {

            }
            return -1;
        }
        public static List<double> DivideLuckyMoney(double totalAmount, int numPeople, double minAmount)
        {
            if (numPeople * minAmount > totalAmount)
            {
                return null; // not enough money to distribute
            }

            var rand = new Random();
            var result = new List<double>(numPeople);

            for (int i = 0; i < numPeople; i++)
            {
                double remainingAmount = totalAmount - (numPeople - i) * minAmount;
                double maxAmount = remainingAmount / (numPeople - i);
                double amount = rand.NextDouble() * (maxAmount - minAmount) + minAmount;
                result.Add(amount);
                totalAmount -= amount;
                Console.WriteLine(amount);
            }            
            return result;
        }
        public class result
        {
            public int Number { get; set; }
        }
        public static string AreaOfCircle(double R)
        {
            var n = 3.14159;
            double A = 0;
            A = n * (R * R);
            //return A.ToString("n4");
            return A.ToString("f4");
        }

        public void First()
        {
           var fast = "excuting first function";
        }
        static void Main(string[] args)
        {
            var result = DivideLuckyMoney(200000, 20, 320);
            // C# Middleware Tutorial //



            //result result = new result();
            //SemaphoreSlim f1 = new(1);
            //SemaphoreSlim f2 = new(1);

            //while(true)
            //{
            //    var t1 = Task.Run(async () =>
            //    {
            //        await f1.WaitAsync();
            //        await Task.Delay(1000);
            //        await f2.WaitAsync();
            //        result.Number++;
            //    });
            //    var t2 = Task.Run(async () =>
            //    {
            //        await f1.WaitAsync();
            //        await Task.Delay(1000);
            //        await f2.WaitAsync();
            //        result.Number++;
            //    });
            //    Console.WriteLine(result.Number);
            //}


            //LeetCodes.MergeTwoLists();

            //string s = "paper", t = "title";
            //LeetCodes.IsIsomorphic(s, t);
            //string s = "ab#c", t = "ad#c";
            //LeetCodes.BackspaceCompare1(s, t);
            //int[] nums = { 1, 7, 3, 6, 5, 6 };
            //var result = LeetCodes.PivotIndex(nums);
            //var result = LeetCodes.RunningSum(nums);
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 }; int k = 3;
            //int[] nums = { -1, -100, 3, 99 }; int k = 2;
            //LeetCodes.Rotate(nums, k);
            //int[] nums = { 2, 7, 11, 15 };
            //int[] arr = new int[] { 1, 4, 3,2 };
            //HackerRank.reverseArray(arr.ToList());
            //int targets = 18;
            //var index = LeetCodes.twoSum(nums, targets);
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine(index[i]);
            //}

            //Console.WriteLine(AreaOfCircle(100.64));
            //string[] words = { "the","dog","got","the","got" };
            //CountFrequencies(words);

            //LuckyMoney(12,2);
            //var second = Calculation.HowManySeconds(2);
            //var str = Calculation.smallerNum("12", "21");
            //Calculation.Addition(0);
            //Console.WriteLine(Calculation.CalculateExponent(5,5));
            //var result = edabit_challenges.smallerNum("16","1500");
            //Console.WriteLine(result);
            //Console.WriteLine(edabit_challenges.Factorial(5));
            //Console.WriteLine(edabit_challenges.triArea(7,4));
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
