using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Arr = new char[5];
            Arr[0] = 'H';
            Arr[1] = 'E';
            Arr[2] = 'l';
            Arr[3] = 'l';
            Arr[4] = 'o';
            int len = (Arr.Length)-1;
            Program obj1 = new Program();
            obj1.quicksort(Arr, 0, len);
            bool result = checkUnique(Arr);
            if (result == true)
            {
                Console.WriteLine("all character in string are unique");
            }
            else
            { Console.WriteLine("there is a duplicate"); }

            Console.ReadLine();
        }

        static bool checkUnique(char []Arr)
    {
        for(int i = 0; i < (Arr.Length) - 1; ++i)
            if(Arr[i] == Arr[i + 1])
                return false;
           
          return true;
    }
 

        public void quicksort(char[] Arr, int l, int r)
        {

            int index = divide(Arr, l, r);
            if(l<index-1)
                quicksort(Arr, l, index-1);
            if(r>index)
                quicksort(Arr, index, r);
        }   
      

        public int divide(char[] arr, int left, int right)
        {
            char pivot = arr[(left + right) / 2];
            while(left<=right)
            {
                while (arr[left] < pivot) left++;
                while (arr[right]> pivot) right--;

                if (left <= right){
                    interchange(arr, left, right);
                     left++;
                    right--;}
            }
            return left;
        }
        

        public void interchange(char[] arr, int a, int b)
        {
            char temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

    }


}

