using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.MyTalkingPets
{
    internal class Animal
    {
        protected int CurrentMealCount;
        // Constructor: 
        public Animal(string nickName, int age, string gender, double energy, double price, double mealCapacity)
        {
            NickName = nickName;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealCapacity = mealCapacity;
        }

        // These are auto-properties: 
        public string NickName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Energy { get; set; }
        public double Price { get; set; }
        public double MealCapacity { get; set; }
        public double GetMealProgress()
        {
            return Math.Round(((double)CurrentMealCount / MealCapacity) * 100);
        }
        public double GetEnergyPercentage()
        {
            return Energy; 
        }
        public virtual void Eat()
        {
            if (CurrentMealCount >= MealCapacity)
            {
                Console.WriteLine("The animal is full.");
                return;
            }
            CurrentMealCount++;
            Price += 1;
            Energy += 10;
            Console.WriteLine($"{NickName} ate a meal. Energy: {Energy}, Price: {Price}");
            if (CurrentMealCount % 10 == 0)
            {
                Age++; MealCapacity++;
                Console.WriteLine($"{NickName} has grown! Age: {Age}, MealCapacity: {MealCapacity}");
            }
        }
        public virtual void Sleep()
        {
            Energy = 100;
            CurrentMealCount = 0;
            Console.WriteLine($"{NickName} slept well. Energy restored!");
        }
        public virtual void Play()
        {
            if (Energy <= 0)
            {
                Console.WriteLine($"{NickName} is too tired to play and will sleep instead.");
                Sleep();
                return;
            }
            Energy -= 15;
            if (Energy < 0) Energy = 0;
            Console.WriteLine($"{NickName} played and used energy. Now Energy: {Energy}");
        }
        private int petCount = 0;

        public virtual void Pet()
        {
            Energy += 5;
            if (Energy > 100)
                Energy = 100;

            Console.WriteLine($"{NickName} enjoyed the petting. Energy: {Energy}");

            petCount++;
            if (petCount % 15 == 0)
            {
                Age++;
                Console.WriteLine($"{NickName} has grown due to your care! Age: {Age}");
            }
        }

    }
}
