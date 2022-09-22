namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int PaladinPower = 100;
        public Paladin(string name, int power = PaladinPower) 
            : base(name, power)
        {

        }
        public override string CastAbility()
        {
            return base.CastAbility() + $"healed for {this.Power}";
        }
    }
}
