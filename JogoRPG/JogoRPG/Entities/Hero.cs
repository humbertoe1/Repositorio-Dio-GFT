using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG.Entities
{
    public class Hero
    {
        protected int Level { get; set; }
        protected string Name { get; set; }
        protected int HealthPoints { get; set; }
        protected int ManaPoints { get; set; }
        protected int Strength { get; set; }
        protected int Agility { get; set; }
        protected int Intelligence { get; set; }
        protected string TypeOfHero { get; set; }

        public Hero(string name, string typeOfHero, int level)
        {
            Level = level;
            Name = name;
            TypeOfHero = typeOfHero;

            HealthPoints = 100 + (level * 10);
            ManaPoints = 100 + (level * 5);
            Strength = 3 + (level);
            Agility = 3 + (level);
            Intelligence = 3 + (level);
        
        }

        public void Info()
        {
           Console.WriteLine($"Name: {this.Name}\nHero Level: {this.Level}\nType of Hero: {this.TypeOfHero}\nHP: {this.HealthPoints} Mana: {this.ManaPoints}");
            
        }

        public virtual string Attack()
        {
            Random luck = new();
            
            int ataque = Strength * 2 + Agility / 2 + Intelligence / 4 + luck.Next(50);
            string pontosDeAtaque = this.Name + " Attacked and caused " + ataque.ToString() + " in damage!";
            
            return pontosDeAtaque;
        }

    }
}
