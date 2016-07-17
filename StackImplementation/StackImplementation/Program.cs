using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {

        //public static void Main()
        //{
        //    stack st = new stack(10);

        //  while(true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("\nStack MENU(size -- 10)");
        //        Console.WriteLine("1. Add an element");
        //        Console.WriteLine("2. See the Top element.");
        //        Console.WriteLine("3. Remove top element.");
        //        Console.WriteLine("4. Display stack elements.");
        //        Console.WriteLine("5. Exit");
        //        Console.Write("Select your choice: ");
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        switch (choice)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter an Element : ");
        //                st.push(Console.ReadLine());
        //                break;
 
        //            case 2: Console.WriteLine("Top element is: {0}", st.Peek());
        //                break;
 
        //            case 3: Console.WriteLine("Element removed: {0}", st.Pop());
        //                break;
 
        //            case 4: st.display();
        //                break;
 
        //            case 5: System.Environment.Exit(1);
        //                break;
        //        }
        //        Console.ReadKey();
        //    }
        //}

    }
}

interface StackADT
{
    Boolean IsEmpty();
    Object Pop();
    object Peek();
    void display();
    void push(object element);
}
class stack : StackADT
{   
    int Stacksize;
    public int top;
    Object[] item;

    public int StackSizeSet
    {
        get{return Stacksize;}
        set{Stacksize = value;}
    }

    public stack(int capacity)
    {
        StackSizeSet = capacity;
        item = new Object[StackSizeSet];
        top = -1;
    }

    public bool IsEmpty()
    {
        if (top == -1) return true;
        return false;
    }

    public void push(object element)
    {
        if (top == (StackSizeSet-1))
        {
            Console.WriteLine("\n the stack is already full");

        }

        else
        { 
            item[++top] = element;
            Console.WriteLine("\n The Item is successfully pushed ");

        }

    }

     public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
 
                return item[top--];
            }
        }
     public object Peek()
     {
         if (IsEmpty())
         {

             Console.WriteLine("Stack is empty!");
             return "No elements";
         }
         else
         {
             return item[top];
         }
     }

     public void display()
     {
         for (int i = top; i > -1; i--)
         {

             Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
         }
     }
}
