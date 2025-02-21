
// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Animal> animals = new List<Animal>();
            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management System!");
                int menu = 0;
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1 Add a Lion: ");
                Console.WriteLine("2 Add a parrot: ");
                Console.WriteLine("3 Display All Animals: ");
                Console.WriteLine("4 Describe an Animal using ZooUtility: ");
                Console.WriteLine("5 Exit");

                try
                {

                    menu = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;

                }

                if (menu == 1)
                {
                    Lion lion = new Lion();
                    Console.Write("Name of Lion: ");
                    lion.Name = Console.ReadLine();
                    Console.Write("Enter the species of the lion:  ");
                    lion.Species = Console.ReadLine();
                    animals.Add(lion);
                    Console.WriteLine("Lion added successfully!");
                }

                else if (menu == 2)
                {
                    Parrot parrot = new Parrot();
                    Console.Write("Name of Parrot: ");
                    parrot.Name = Console.ReadLine();
                    Console.Write("Enter the species of the Parrot:  ");
                    parrot.Species = Console.ReadLine();
                    Console.WriteLine("Parrot added successfully!");

                    animals.Add(parrot);
                }
                else if (menu == 3)
                {
                    foreach (Animal animal in animals)
                    {
                        Console.WriteLine($" {animal.Name} {animal.Species}");
                        animal.MakeSound();



                    }
                }
                else if (menu == 4)
                {
                    ZooUtility.DescribeAnimal("");
                
                }

                else if (menu == 5)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                }

             }
        } 
    }

