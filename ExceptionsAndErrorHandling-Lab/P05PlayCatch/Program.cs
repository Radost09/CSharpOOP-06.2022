using System;
using System.Collections.Generic;
using System.Linq;

namespace P05PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int exceptionsCount = 0;

            while(exceptionsCount != 3)
            {
                string[] command = Console.ReadLine().Split();
                string cmdType = command[0];

                try
                {
                    switch(cmdType)
                    {
                        case "Replace":
                            {
                                int index = int.Parse(command[1]);
                                int element = int.Parse(command[2]);
                                numbers[index] = element;
                                break;
                            }
                        case "Print":
                            {
                                int startIndex = int.Parse(command[1]);
                                int endIndex = int.Parse(command[2]);

                                List<int> rangeToPrint = new List<int>();

                                for (int i = startIndex; i <= endIndex; i++)
                                {
                                    rangeToPrint.Add(numbers[i]);
                                }
                                Console.WriteLine(string.Join(", ", rangeToPrint));
                                break;
                            }
                        case "Show":
                            {
                                int index = int.Parse(command[1]);
                                Console.WriteLine(numbers[index]);
                                    break; ;
                            }
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCount++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
