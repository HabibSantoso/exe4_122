using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_122
{
    class Stack
    {
        private char[] data;
        private int top;
        private int max;

        public Stack(int size)
        {
            
            data = new char[size];
            top = -1;
            max = size;
        }

        public void push(char value)
        {
            if (top == max - 1)
            {
                Console.WriteLine("\nStack is Full!!! Insertion is not possible!!!");
                return;
            }
            else
            {
                top++;
                data[top] = value;
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack is Empty!!! Deletion is not possible!!!");
            }
            else
            {
                Console.WriteLine("Poped element is: " + data[top]);
                top--;
            }
        }

        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for(int i = top; i >=0; i--)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + data[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int size = 9 + 22 + 1 + 2 * 10 - 10;
            Stack s = new Stack(size);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4 Exit");
                Console.Write("\nEnter your choice: ");
                String sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number: ");
                        String inchar = Console.ReadLine();
                        char fixchar = Convert.ToChar(inchar);
                        s.push(fixchar);
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            }
        }
    }
}
