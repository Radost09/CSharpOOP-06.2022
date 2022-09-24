﻿using System;

namespace P04SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;

            foreach (var item in input)
            {
                try
                {
                    int number = int.Parse(item);
                    sum += number;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch(OverflowException ofe)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
