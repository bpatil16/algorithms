using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Problem no 6 for arrays


namespace Answer1
{
    class Program6
    {

        public int SplitArr(int[] A, int n)
        {
            int result = 0;
            int x = 0;
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total = total + A[i];
            }

            if ((total % 2) != 0)
                result = -1;
            else
            {
                x = total / 2;

                for (int j = 0; j < n; j++)
                {
                    if (A[j] == x)
                        result = x;
                }

            }
            return result;
        }

        //static void Main()
        //{
        //    int[] Arr = new int[] { 2, 1, 7, 1 };
        //    int Len = Arr.Length;
        //    Program6 Obj6 = new Program6();
        //    int x = Obj6.SplitArr(Arr, Len);
        //   // Console.WriteLine("\n The number which is sum of n-1 elements is: " + x);
        //    if (x == -1)
        //    {
        //        Console.WriteLine("\n Element which is sume of n-1 elements doesnt exist");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n The number which is sum of n-1 elements is: " + x);
        //    }
        //    Console.ReadLine();


        //}
    }
}
