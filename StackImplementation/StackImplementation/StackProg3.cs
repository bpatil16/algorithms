using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program to reverese Stack 

namespace StackImplementation
{
    class StackProg3
    {
        public static void Main()
        {
            string S = "1234";
            int len = S.Length;
            stack st1_old = new stack(len);
            stack st2 = new stack(len);
            object temp = 0;

            foreach (char c in S)
            {
                st1_old.push(c.ToString());
            }

            Console.WriteLine("\n Display original stack :\n ");
            st1_old.display();

            while (len > 0)
            {
                temp = st1_old.Pop();
                int i = 1;

                while (len - i > 0)
                {
                    st2.push(st1_old.Pop());
                    i++;

                }

                st1_old.push(temp);

                int j = 1;
                while (len - j > 0)
                {
                    st1_old.push(st2.Pop());
                    j++;
                }

                len--;

            }
            Console.WriteLine("\n Display reveresed stack: \n ");

            st1_old.display();
            Console.ReadLine();



        }
    }
}
