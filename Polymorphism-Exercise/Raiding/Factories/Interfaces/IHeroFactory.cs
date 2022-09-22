using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        BaseHero CreateHero(string name, string type);
    }
}
