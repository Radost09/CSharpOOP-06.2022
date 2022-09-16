
namespace P03Telephony
{
    using System;
    public class StationaryPhone : ICall
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
