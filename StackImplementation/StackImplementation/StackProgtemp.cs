using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class StackProgtemp
    {
        public int eval(string S)
        {
            
            int len = S.Length;


            stack Val = new stack(len - 1);
            stack opr = new stack(len - 1);


            foreach (char c in S)
            {
                if ((c) > 48 && c <= 57)

                    Val.push(Convert.ToInt32(c.ToString()));

                else if (c == 43 || c == 45 ||
                   c == 42 || c == 47)
                {

                    while (!opr.IsEmpty() && findPrecedence(c, (char)opr.Peek()))
                        Val.push((evalOp((Char)opr.Pop(), Convert.ToInt32(Val.Pop()), Convert.ToInt32(Val.Pop()))));
                            
                    opr.push(c);

                }
            }
                while (!opr.IsEmpty())
                    Val.push(evalOp((char)opr.Pop(), Convert.ToInt32(Val.Pop()), Convert.ToInt32(Val.Pop())));

                return Convert.ToInt32(Val.Pop());
            
        }
        public static int evalOp(char op, int a, int b)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            }
            return 0;
        }
        // return true if op2 has higher precedence

        public static Boolean findPrecedence(char op1, char op2)
        {
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            else
                return true;
        }

        //public static void Main()
        //{

        //    StackProgtemp obj2 = new StackProgtemp();

        //    int result = obj2.eval("5+5*2");
        //    Console.WriteLine("the result is " + result);
        //    Console.ReadLine();
        //}
    }
}