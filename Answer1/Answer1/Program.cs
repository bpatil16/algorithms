using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// SOLUTION OF PROBLEM 1 IN ARRAY DATA STRUCTURE ///

namespace Answer1
{
    class Program
    {
        public void Test(int[] A, int low , int high)
        {
            int i = 0;
            if (low > high)
                return;
            if (low == high)
            {
                Console.WriteLine("\n The required element which is unique is " + A[low]);
                Console.ReadLine();
            }
            int mid = (low + high) / 2;

            if (mid % 2 == 0)
            {
                if (A[mid] == A[mid + 1])
                    Test(A, mid +2 , high);
                else
                    Test(A, low, mid);
            }
            else {
                if (A[mid] == A[mid - 1])
                    Test(A, mid-2 , high);
                else
                    Test(A, low, mid - 1);
            }
        }
        //static int Main()
        //{

        //    int[] Arr = new int[] { 1, 1, 2, 2, 4, 4, 5, 5, 6};
        //    int Len = (Arr.Length) - 1;
        //    Program MyObj = new Program();
        //    MyObj.Test(Arr,0, Len);
        //    return 0;
        //    Console.ReadLine();

        //}

    }
}
