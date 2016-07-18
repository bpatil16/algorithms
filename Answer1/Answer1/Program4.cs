using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem no 4 for arrays

namespace Answer1
{
    class Program4
    {
        public void findDup(int[] A, int n)
        {
            int SumIndex = 0;
            int SumElements = 0;
            int diff = 0;
            int i = 0;

            while (i < n)
            {
                SumIndex = SumIndex + i;
                SumElements = SumElements + A[i];
                i++;
            }

            diff = SumElements - SumIndex;

            Console.WriteLine("\n The duplicate element is: " + diff);
        }


        //static void Main()
        //{
        //    int[] Arr = { 2, 3, 4, 1, 2};
        //    int n = Arr.Length;
        //    Program4 obj4 = new Program4();
        //    obj4.findDup(Arr, n);
        //    Console.ReadLine();
        //}
    }
}

