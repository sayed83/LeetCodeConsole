using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public class HackerRank
    {
        public static List<int> reverseArray1(List<int> a)
        {
            List<int> list = Enumerable.Reverse(a).ToList();
           
            return list;
        }

        public static List<int> reverseArray(List<int> a)
        {
            List<int> res = new List<int>();
            int _count = a.Count() - 1;
            for (int i = _count; i >= 0; i--)
            {
                res.Add(a[i]);
            }
            return res;
        }

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {

            List<List<int>> arr = new List<List<int>>();
            List<int> answer = new List<int>();
            int lastAnswer = 0;

            //fill 2d array
            for (int i = 0; i < n; i++)
            {
                arr.Add(new List<int>());
            }

            for (int i = 0; i < queries.Count; i++)
            {
                //List<int> query = queries.Ge(i);
                //int type = query.get(0);
                //int x = query.get(1);
                //int y = query.get(2);

                //if (type == 1)
                //{
                //    int idx = (x ^ lastAnswer) % n;
                //    arr.get(idx).add(y);

                //}
                //else if (type == 2)
                //{
                //    int idx = (x ^ lastAnswer) % n;
                //    lastAnswer = arr.get(idx).get(y % arr.get(idx).size());

                //    answer.add(lastAnswer);
                //}

            }

            return answer;
        }
    }
}
