using System;

namespace P01SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                double result = GetSqrt(number);
                Console.WriteLine(result);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        
        }

        private static double GetSqrt(int number)
        {
            if(number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }
            return Math.Sqrt(number);
        }
    }
}
