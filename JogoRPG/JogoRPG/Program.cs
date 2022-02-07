using System;
using JogoRPG.Entities;
namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //without OOP:
            string nome = "Arus";
            int level1 = 12;
            string tipoHeroi = "Guerreiro";

            Console.WriteLine($"{nome} {level1} {tipoHeroi} ");

            string nome2 = "Wedge";
            int level2 = 20;
            string tipoHeroi2 = "Ninja";

            Console.WriteLine($"{nome2} {level2} {tipoHeroi2} ");


            //with OOP:
            string name, typeOfHero;
            int level;

            name = "Invoker";
            level = 16;
            typeOfHero = "Mage";
            Mage invoker = new(name, typeOfHero, level);

            invoker.Info();

            Console.WriteLine(invoker.Attack());

            name = "Dragon Knight";
            level = 16;
            typeOfHero = "Warrior";
            Warrior dk = new(name, typeOfHero, level);

            dk.Info();

            
            Console.WriteLine(dk.Attack());

            name = "Anti-Mage";
            level = 16;
            typeOfHero = "Ninja";
            Ninja am = new(name, typeOfHero, level);

            am.Info();

            Console.WriteLine(am.Attack());
            




        }
    }
}
