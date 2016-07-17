using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    class Program6
    {

        public void SplitArr (int [] A, int n )
    {
        int[] SumA = new int[1];

        int[] RestA = new int[n - 1];

        int total = 0;

        for(int i = 0; i<n; i++)
        {
            total = total + A[i]; 
        }

        SumA[0] = total;

        for (int j = 0; j<n; j++)
        {
            RestA[j] = A[j];
        }

        foreach (var item in SumA)
        {
            Console.WriteLine("\n Array1: Sum of n-1 elements:");
            Console.Write(item.ToString());
        }


        foreach (var item in RestA)
        {
            Console.WriteLine("\n Array2: All n-1 elements:");
            Console.Write(item.ToString());
        }


    }

        //static void Main()
        //{
        //    int[] Arr = new int[] { 1, 4, 5, 6 };
        //    int Len = Arr.Length;
        //    Program6 Obj6 = new Program6();
        //    Obj6.SplitArr(Arr, Len);
        //    Console.ReadLine();

        //}
    }
}
