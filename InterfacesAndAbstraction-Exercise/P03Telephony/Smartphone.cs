
namespace P03Telephony
{
    using System;
    public class Smartphone : ICall, IBrowse
    {
        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Browse(string site)
        {
            Console.WriteLine($"Browsing: {site}");
        }
    }
}
