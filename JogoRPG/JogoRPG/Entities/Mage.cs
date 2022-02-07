using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.Entities
{
    public class Mage : Hero
    {
        public Mage(string name, string typeOfHero, int level) : base(name,  typeOfHero, level)
        {
            HealthPoints = 100 + (level * 10);
            ManaPoints = 200 + (level * 5);
            Strength = 3 + (level);
            Agility = 5 + (level);
            Intelligence = 5 * (level);
        }
        public override string Attack()
        {
            Random luck = new();

            int ataque = this.Strength/4 + this.Agility / 2 + this.Intelligence*2 + luck.Next(50);
            string pontosDeAtaque = this.Name + " Cast a spell deliverying " + ataque.ToString() + " in damage!";

            return pontosDeAtaque;
        }
    }
}
