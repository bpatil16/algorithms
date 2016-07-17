using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    class Program5
    {
        public int findkey(int [] A, int n, int key)
        {
            int i = 0;
                
                while (i<n)
                {
                    if(A[i] == key)
                     return i;
                    i= i +  Math.Abs(A[i] - key);
                }
            Console.WriteLine("\n Element doest exist");
            return -1;
        }

        //static void Main()
        //{
        //    int[] Arr = { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 };
        //    int n = Arr.Length;
        //    int x = 2;
        //    Program5 obj5 = new Program5();
        //    int i = obj5.findkey(Arr, n, x);
        //    Console.WriteLine("\nElement: ");
        //    Console.WriteLine(x);
        //    Console.WriteLine("is found at index: ");
        //    Console.WriteLine(i);
        //    Console.ReadLine();
        //}

     }
}
