
namespace P03Telephony
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] webSites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ICall phone;

            foreach (var phoneNumber in phoneNumbers)
            {
                if(!Regex.IsMatch(phoneNumber, @"^[0-9]+$"))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if(phoneNumber.Length == 7)
                {
                    phone = new StationaryPhone();
                    
                }
                else
                {
                    phone = new Smartphone();
                }

                phone.Call(phoneNumber);
            }

            IBrowse smartPhone = new Smartphone();
            foreach (var site in webSites)
            {
                if(!Regex.IsMatch(site, @"^[^\d+]+$"))
                {
                    Console.WriteLine($"Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {site}!");
                }
            }
        }
    }
}
