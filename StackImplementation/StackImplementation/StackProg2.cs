using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class StackProg2
    {
        public int eval(string S)
        {
            char[] tokens = S.ToCharArray();
            int len = S.Length;


            stack Val = new stack(len - 1);
            stack opr = new stack(len - 1);


            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] > '0' && tokens[i] <= 9)

                    Val.push(Convert.ToInt32(tokens[i]));

                else if (tokens[i] == '+' || tokens[i] == '-' ||
                    tokens[i] == '*' || tokens[i] == '/')
                {

                    while (!opr.IsEmpty() && findPrecedence(tokens[i], (char)opr.Peek()))
                        Val.push(
                            evalOp((Char)opr.Pop(), Convert.ToInt32(Val.Pop()), Convert.ToInt32(Val.Pop()))
                            );
                    opr.push(tokens[i]);

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

        public static void Main()
        {

            StackProg2 obj2 = new StackProg2();

            int result = obj2.eval("2 + 2 * 6");
        }

    }
}
