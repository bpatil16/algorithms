using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    public class Subarray
    {

        public class IndexInArray
        {
            public int start = 0;
            public int end = 0;
        }

        public void Test2(int[] input)
        {

            //define output list to store index for printing result

            var output = new List<IndexInArray>();


            // declare dictionary  to store value and index of elements sum     

            var ht = new Dictionary<int, List<int>>();

            // Maintains sum of elements so far
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                if (sum == 0)
                {
                    output.Add(new IndexInArray { start = 0, end = i });
                }
                if (ht.ContainsKey(sum))
                {
                    List<int> vc = ht[sum];
                    foreach (var id in vc)
                    {
                        output.Add(new IndexInArray { start = (id + 1), end = i });
                    }
                    vc.Add(i);
                }
                else
                {
                    ht.Add(sum, new List<int>() { i });
                }
            }

            //print output
            foreach (var o in output)
            {
                Console.WriteLine("Found subarray with start={0}, end={1}", o.start, o.end);
            }
        }

        public static void Main()
        {
            int[] input = new int[] { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

            Subarray Obj7 = new Subarray();
            Obj7.Test2(input);
            Console.ReadLine();

        }




    }


}
