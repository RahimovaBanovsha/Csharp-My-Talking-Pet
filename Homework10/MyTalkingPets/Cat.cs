using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.MyTalkingPets
{
    internal class Cat: Animal
    {
        public int LivesLeft { get; set; } = 9;
        public Cat(string nickName, int age, string gender, double energy, double price, double mealCapacity)
                : base(nickName, age, gender, energy, price, mealCapacity) {}
        public override void Eat()
        {
            if (Energy >= 100)
            {
                Console.WriteLine($"{NickName} sniffs the food and walks away.");
                return;
            }
            base.Eat(); 
            Console.WriteLine($"{NickName} purrs softly after eating and licks its paw.");
        }
        public override void Play()
        {
            if (Energy <= 0)
            {
                Console.WriteLine($"{NickName} stares at you silently and curls up for a nap.");
                Sleep();
                return;
            }

            Energy -= 10;
            if (Energy < 0) Energy = 0;

            Console.WriteLine($"{NickName} chases a laser pointer and acts superior. Energy: {Energy} 😼");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine($"{NickName} stretches elegantly, yawns, and curls into a ball.");
        }
    }
}
