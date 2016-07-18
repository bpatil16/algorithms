using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// SOLUTION TO PROBLEM 2 //


namespace Answer1
{
    class Program1
    {
        public void Test(int[] A, int size)
        {
            if(A[size / 2] > size)
            {
                Console.WriteLine("Magic index might be on Left\n");
                for (int i = 0; i <= (size / 2); i++)
                {

                   if(A[i] == i)
                    {
                        Console.WriteLine("The Magic index is: \n");
                        Console.WriteLine(A[i]);
                        
                    }
                    else
                    {
                        Console.WriteLine("\n Magic index doesn't exit");
                        break;
                    }
                }
            }
            else if (A[size / 2] == (size/2))
            {
                Console.WriteLine("\n Magic index is in middle:");
                Console.WriteLine((size/2));
                for (int i = 0; i < (size / 2); i++)
                {

                    if (A[i] == i)
                    {
                        Console.WriteLine("The Magic index on left are: \n");
                        Console.WriteLine(A[i]);

                    }
                }
              
            }

            else if (A[size / 2] < (size / 2))
            {
                Console.WriteLine("\n Magic index is on left or right: ");
                for (int i = 0; i < (size); i++)
                {

                    if (A[i] == i)
                    {
                        Console.WriteLine("\n The Magic index on both sides are: \n");
                        Console.WriteLine(A[i]);

                    }
                }

            }

        }


        //static void Main()
        //{
        //    int[] Arr = new int[] { 0, 0, 1, 3, 15 };
        //    int Len = (Arr.Length) - 1;
        //    Program1 Obj2 = new Program1();
        //    Obj2.Test(Arr, Len);
        //    Console.ReadLine();

        //}
    }
}