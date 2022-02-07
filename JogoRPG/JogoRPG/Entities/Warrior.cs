using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.Entities
{
    class Warrior : Hero
    {
        public Warrior(string name, string typeOfHero, int level) : base(name, typeOfHero, level)
        {
            HealthPoints = 300 + (level * 10);
            ManaPoints = 50 + (level * 5);
            Strength = 5 * (level);
            Agility = 5 + (level);
            Intelligence = 3 + (level);
        }
        public override string Attack()
        {
            Random luck = new();

            int ataque = this.Strength * 2 + this.Agility / 2 + this.Intelligence / 4 + luck.Next(50);
            string pontosDeAtaque = this.Name + " Strikes a blow and causes " + ataque.ToString() + " in damage!";

            return pontosDeAtaque;
        }
    
    }
}
