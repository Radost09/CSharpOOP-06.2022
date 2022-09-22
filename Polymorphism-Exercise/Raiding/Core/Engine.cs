namespace Raiding.Core
{
    using Raiding.Core.Interfaces;
    using Raiding.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class Engine : IEngine
    {
        private readonly BaseHero druid;
        private readonly BaseHero paladin;
        private readonly BaseHero rogue;
        private readonly BaseHero warrior;

        private readonly List<BaseHero> heroesList;
        public Engine()
        {
            this.heroesList = new List<BaseHero>();
        }
        public Engine(BaseHero druid, BaseHero paladin, BaseHero rogue, BaseHero warrior)
            : this()
        {
            this.druid = druid;
            this.paladin = paladin;
            this.rogue = rogue;
            this.warrior = warrior;
        }

        public void Start()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    heroesList.Add(new Druid(heroName));
                }
                else if (heroType == "Paladin")
                {
                    heroesList.Add(new Paladin(heroName));
                }
                else if (heroType == "Rogue")
                {
                    heroesList.Add(new Rogue(heroName));
                }
                else if (heroType == "Warrior")
                {
                    heroesList.Add(new Warrior(heroName));
                }
                else
                {
                    Console.WriteLine("Invalid hero");
                }

            }
            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroesList)
            {
                Console.WriteLine(hero.CastAbility());
            }
            var sum = heroesList.Select(x => x.Power).Sum();

            if (sum >= bossPower)
            {
                Console.WriteLine($"Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
