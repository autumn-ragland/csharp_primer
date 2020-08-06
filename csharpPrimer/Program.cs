using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#"); 
            /*
            Output a method below to see the basics of C# at work!
            */

            /*
            Outputing to the console
            Reading input to the console
            Declaring variables
            String Templating
            */
            // Introduction();

            /*
            Define a class
            Declare a new instance of a class
            Access properties of an object using dot notation
            Use enumerated types
            */
            // DefineClasses();

            /*
            Defining Arrays
            Accessing Elements in an Array
            Array Methods
            */
            // DefineListsAndArrays();

            /*
            Define a list of objects
            LinQ select statement
            ToList method
            First or Default method
            */
            // UsingLinq();

            /*

            */
            // UsingConditionals();

            /*
            
            */
            // UsingLoops();

        }

        static void Introduction()
        {
            Console.Write("Enter your name:"); // Output to the console
            string userName; // variable declaration
            userName = Console.ReadLine(); // Input from the console and var
            Console.WriteLine($"Hello {userName}"); // String Templating
        }

        static void DefineClasses()
        {
            Console.WriteLine("Defining Classes");
            /*
            Classes are a reference type and an object created based off the properties of a class must be instanciated using the new keyword. That object's type is now tied to the class.
            */

            PetClass pet1 = new PetClass(); // create a new instance of the class
            // define the properties of the new pet object
            pet1.Name = "Dakota";
            pet1.Age = 9;
            pet1.Type = PetType.Dog;  // enumerated type define outside of the class
            pet1.Trainned = true;
            // Access each property of the new pet object using dot notation
            Console.WriteLine($"Congrats on your new {pet1.Type}! {pet1.Name} is {pet1.Age} years old. It is {pet1.Trainned} that they are trainned.");

            PetClass pet2 = new PetClass();
            pet2.Name = "Eddie";
            pet2.Age = 4;
            pet2.Type = PetType.Cat;
            pet2.Trainned = true;
            Console.WriteLine($"Congrats on your new {pet2.Type}! {pet2.Name} is {pet2.Age} years old. It is {pet2.Trainned} that they are trainned.");

            PetClass pet3 = new PetClass();
            pet3.Name = "Bully";
            pet3.Age = 1;
            pet3.Type = PetType.Dog;
            pet3.Trainned = false;
            Console.WriteLine($"Congrats on your new {pet3.Type}! {pet3.Name} is {pet3.Age} years old. It is {pet3.Trainned} that they are trainned.");

        }

        static void DefineListsAndArrays()
        {
            Console.WriteLine("Defining Lists and Arrays!");
            /*
            Arrays and lists are similar is structure in that both are a strongly typed collection of items with a zero based index. Arrays cannot be altered or extended after creation. Lists are able to be altered and extended and built in methods such as Add, Remove, and Sort make these alteration much simplier. 
            */

            int[] intArray = new int[]{1,3,5,7,9}; // define an array of integers
            string[] strArray = new string[]{"Autumn", "Erin", "Kevin", "Meka"}; // define an array of strings

            // Access elements of an array by index position and return length of array using Length method
            Console.WriteLine($"The second element in the intArray is {intArray[1]} and the array is {intArray.Length} elements long");
            Console.WriteLine($"The second element in the strArray is {strArray[1]} and the array is {strArray.Length} elements long");

            List<int> intList = new List<int>(); // declare a list of integers
            // add integers to the list
            intList.Add(8);
            intList.Add(6);
            intList.Add(2);
            intList.Add(4);
            List<string> strList = new List<string>(); // declare a list of strings
            // add strings to the array
            strList.Add("Damien");
            strList.Add("JP");
            strList.Add("Jeffery");
            // Access elements of a list by index position and return length of array using Count method
            Console.WriteLine($"The second element in the intList is {intList[1]} and the array is {intList.Count} elements long");
            Console.WriteLine($"The second element in the strList is {strList[1]} and the array is {strList.Count} elements long");

            Console.WriteLine("*******Prefrom some more list methods and see the change!*******");
            // List Sort method
            intList.Sort();
            // List Remove method
            strList.Remove(strList[1]);
            // Output after sort and remove
            Console.WriteLine($"The second element in the intList is {intList[1]} and the array is {intList.Count} elements long");
            Console.WriteLine($"The second element in the strList is {strList[1]} and the array is {strList.Count} elements long");
        }

        static void UsingLinq()
        {
            Console.WriteLine("Using LinQ Query Operations");
            // Define a list of PetClass objects
            List<PetClass> petList = new List<PetClass>();
            petList.Add(new PetClass{Name = "Dory", Age = 3, Type = PetType.Fish, Trainned = true});
            petList.Add(new PetClass{Name = "Taffy", Age = 8, Type = PetType.Dog, Trainned = false});
            petList.Add(new PetClass{Name = "Midnight", Age = 7, Type = PetType.Cat, Trainned = false});
            petList.Add(new PetClass{Name = "Ally", Age = 1, Type = PetType.Cat, Trainned = true});

            // return an array of cats from the list of pet objects
            List <PetClass> petResults = (from p in petList where p.Type == PetType.Cat select p).ToList();
            Console.WriteLine($"There are {petResults.Count} cats in the list of pet objects!");

            // return an array of dogs from the list of pet objects
            List <PetClass> petResults2 = petList.Where(pet => pet.Type == PetType.Dog).ToList();
            Console.WriteLine($"There are {petResults2.Count} dogs in the list of pet objects!");

            // return the pet names "Dory" form the list of pet objects
            PetClass petResults3 = petList.Where(pet => pet.Name == "Dory").FirstOrDefault();
            Console.WriteLine($"{petResults3.Name} has been found");
        }

        static void UsingConditionals()
        {
            Console.WriteLine("Using Conditionals");
        }

        static void UsingLoops()
        {
            Console.WriteLine("Using Loops");
        }

    }
    class PetClass  
    {
        public string Name;
        public int Age;
        public PetType Type;
        public bool Trainned;
        
    }

    enum PetType
    {
        Dog, Cat, Fish, Bird, Exotic
    }
}
