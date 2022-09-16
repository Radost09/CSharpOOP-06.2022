
namespace P04BorderControl
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> collection = new List<IIdentifiable>();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] personalInfo = command.Split(' ');
                if(personalInfo.Length == 3)
                {
                    string citizenName = personalInfo[0];
                    int citizenAge = int.Parse(personalInfo[1]);
                    string citizenId = personalInfo[2];
                    IIdentifiable citizen = new Citizen(citizenName, citizenAge, citizenId);
                    collection.Add(citizen);
                }
                else if(personalInfo.Length == 2)
                {
                    string robotModel = personalInfo[0];
                    string robotId = personalInfo[1];
                    IIdentifiable robot = new Robot(robotModel, robotId);
                    collection.Add(robot);
                }
                
            }
            string lastDigitsOfId = Console.ReadLine();

            foreach (var item in collection)
            {
                if(item.Id.EndsWith(lastDigitsOfId))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
