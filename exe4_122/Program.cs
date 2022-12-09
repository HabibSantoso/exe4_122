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
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
