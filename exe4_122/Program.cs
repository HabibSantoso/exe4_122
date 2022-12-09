using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_122
{
    class Stack
    {
        private char[] ele;
        private int top;
        private int max;

        public Stack(int size)
        {
            size = 9 + 22 + 1 + 2 * 10 - 10;
            ele = new char[size];
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
                ele[top] = value;
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack is Empty!!! Deletion is not possible!!!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
