using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a stack
            var names = new Stack<string>();

            //add elements into stack
            names.Push("Shihab");
            names.Push("Mishu");
            names.Push("Rayhan");

            //Iterate the stack
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //peek a element
            Console.WriteLine(names.Peek());

            //pop a element
            Console.WriteLine(names.Pop());

        }
    }
}
