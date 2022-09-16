namespace P05BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> collection = new List<IBirthable>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] personalInfo = command.Split(' ');
                string creature = personalInfo[0];

                switch(creature)
                {
                    case "Citizen":
                        {
                            string citizenName = personalInfo[1];
                            int citizenAge = int.Parse(personalInfo[2]);
                            string citizenId = personalInfo[4];
                            string citizenBday = personalInfo[4];
                            IBirthable citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBday);
                            collection.Add(citizen);
                            break;
                        }
                    case "Pet":
                        {
                            string petName = personalInfo[1];
                            string petBday = personalInfo[2];
                            IBirthable pet = new Pet(petName, petBday);
                            collection.Add(pet);
                            break;
                        }
                    case "Robot":
                        {
                            string robotModel = personalInfo[1];
                            string robotId = personalInfo[2];
                            continue;
                        }
                }
            }
            string yearToCheck = Console.ReadLine();

            foreach (var item in collection)
            {
                if (item.Birthdate.EndsWith(yearToCheck))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
