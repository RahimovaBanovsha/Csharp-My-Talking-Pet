using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.MyTalkingPets
{
    internal class Dog:Animal
    {
        public bool IsTrained { get; set; } = false;
        public Dog(string nickName, int age, string gender, double energy, double price, double mealCapacity)
                 : base(nickName, age, gender, energy, price, mealCapacity) { }
        public override void Play()
        {
            if (Energy <= 0)
            {
                Console.WriteLine($"{NickName} is too tired and lies down quietly...");
                Sleep();
                return;
            }

            Energy -= 20; 
            if (Energy < 0) Energy = 0;

            Console.WriteLine($"{NickName} runs and chases a ball! Energy now: {Energy}");

            if (!IsTrained)
            {
                IsTrained = true;
                Console.WriteLine($"{NickName} is now trained and can fetch sticks!");
            }
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"{NickName} wolfs down the food happily!");
        }
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine($"{NickName} snores loudly while dreaming of bones.");
        }

    }
}
