namespace Raiding.Models
{
    using Raiding.Models.Interfaces;

    public abstract class BaseHero : IBaseHero
    {
        private string name;
        private int power;
        private string type;
        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Power 
        { 
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} ";
        }
    }
}
