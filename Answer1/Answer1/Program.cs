using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    class Program
    {
        public void Test(int[] A, int size)
        {
            int i = 0;

            while (i <= size)
            {
                if (A[i] == A[i + 1])
                {
                    i = i + 2;
                }
                else
                {
                    Console.WriteLine(A[i]);
                    break;
                }
            }
        }
        //static void Main()
        //{

        //    int[] Arr = new int[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
        //    int Len = (Arr.Length) - 1;
        //    Program MyObj = new Program();
        //    MyObj.Test(Arr, Len);
        //    Console.ReadLine();

        //}

    }
}
