using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            Console.WriteLine(stackOfStrings.IsEmpty());

            List<string> strings = new List<string>() { "Pesho", "Gosho", "34" };
            stackOfStrings.AddRange(strings);

            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.IsEmpty());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.IsEmpty());
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
