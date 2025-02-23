using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class ZooUtility 

    {
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"Species {species}"); 
        }

        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name,species);
            Console.WriteLine($"Age {age}");
        }
    }
}
