using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    class Program3
    {
        public int search(int [] A, int l, int h, int key)
        {
            if(l>h) 
                return -1;

            int mid = (l + h)/2;

            if(A[mid] == key) return mid;
            
            if(A[l] <= A[mid])
            {
                if(key >= A[l] && key <= A[mid])
                {
                    return search(A, l, mid-1,key);
                } 
                return search(A, mid+1, h, key);
            }

            if (key >= A[mid] && key <= A[h])
            { 
                return search(A,mid+1,h,key);
            }
            return search(A, l, mid - 1, key);

        }
        //static void Main()
        //{
        //    int[] Arr = { 1, 2, 3, 4, 5 };
        //    int n = Arr.Length;
        //    int key = 5;
        //    Program3 Obj3 = new Program3();

        //    int i = Obj3.search(Arr, 0, n - 1, key);
        //    if (i != -1)
        //    {
        //        Console.WriteLine("index for key is: ");
        //        Console.WriteLine(i);
        //    }
        //    else Console.WriteLine("Key not found\n");
        //    Console.ReadLine();
        //}
         
    }

}
