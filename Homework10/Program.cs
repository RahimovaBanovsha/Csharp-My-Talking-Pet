using Homework10.MyTalkingPets;
using System;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Luna", 2, "Female", 50, 90, 3);
            Dog dog = new Dog("Rex", 3, "Male", 70, 120, 4);

            //Console.WriteLine("----- CAT ACTIONS -----");
            //cat.Eat();       
            //cat.Play();      
            //cat.Sleep();     

            //Console.WriteLine("\n----- DOG ACTIONS -----");
            //dog.Eat();       
            //dog.Play();      
            //dog.Sleep();     
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== My Talking Pets ===");
                Console.WriteLine("1. Interact with Cat (Luna)");
                Console.WriteLine("2. Interact with Dog (Rex)");
                Console.WriteLine("0. Exit");

                Console.Write("\nChoose a pet: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InteractWithPet(cat);
                        break;
                    case "2":
                        InteractWithPet(dog);
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Console.ReadLine();
                        break;
                }
            }

        }
        static void InteractWithPet(Animal pet)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {pet.NickName}'s Status ===");
                Console.WriteLine($"Energy: {pet.GetEnergyPercentage()}%");
                Console.WriteLine($"Meal Progress: {pet.GetMealProgress()}%");
                Console.WriteLine($"Age: {pet.Age}");
                Console.WriteLine($"Price: {pet.Price} AZN");
                Console.WriteLine($"Status: {(pet.Energy <= 0 ? "Sleeping" : "Awake")}");
                Console.WriteLine();

                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Sleep");
                Console.WriteLine("4. Pet");
                Console.WriteLine("5. Buy Food");
                Console.WriteLine("6. Renovate House");
                Console.WriteLine("7. Buy Clothes");
                Console.WriteLine("0. Back to main menu");

                Console.Write("\nChoose an action: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        pet.Eat();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Sleep();
                        break;
                    case "4":
                        pet.Pet();
                        break;
                    case "5":
                        Console.WriteLine($"{pet.NickName} bought food.");
                        pet.Price += 2;
                        break;
                    case "6":
                        Console.WriteLine($"{pet.NickName}'s house was renovated.");
                        pet.Price += 10;
                        pet.Energy -= 5;
                        if (pet.Energy < 0) pet.Energy = 0;
                        break;
                    case "7":
                        Console.WriteLine($"{pet.NickName} bought clothes.");
                        pet.Price += 5;
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }


            }
        }
    }
}
