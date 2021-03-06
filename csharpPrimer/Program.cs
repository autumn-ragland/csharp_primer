﻿using System; // required for Console methods
using System.Collections.Generic; // required for list and array methods
using System.Linq; // required for LINQ methods

namespace csharpPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#"); 
            /*
            Comment in a method below to see the basics of C# at work!
            */
            // Introduction();
            // DefineClasses();
            // DefineListsAndArrays();
            // UsingLinq();
            // UsingConditionals();
            // UsingLoops();

        }
        /// <summary>method <c>Introduction</c>
        /// 
        /// - Outputing to the console
        /// - Reading input to the console
        /// - Declaring variables
        ///  - String Templating
        /// </summary>
        static void Introduction()
        {
            Console.Write("Enter your name:"); // Output to the console
            string userName; // variable declaration
            userName = Console.ReadLine(); // Input from the console and var
            Console.WriteLine($"Hello {userName}"); // String Templating
        }

        /// <summary>method <c>DefineClasses</c>
        ///
        /// - Define a class
        /// - Declare a new instance of a class
        /// - Access properties of an object using dot notation
        /// - Use enumerated types
        /// </summary>
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

        /// <summary>method <c>DefineListsAndArrays</c>
        ///
        /// - Defining Arrays
        /// - Accessing Elements in an Array
        /// - Array Methods
        /// </summary>
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

        /// <summary>method <c>UsingLinq</c>
        ///
        /// - Define a list of objects
        /// - LINQ select statement
        /// - ToList method
        /// - First or Default method
        /// </summary>
        static void UsingLinq()
        {
            Console.WriteLine("Using LINQ Query Operations");
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

        /// <summary>method <c>UsingConditionals</c>
        ///
        /// - Type Conversion
        /// - If Statements
        /// </summary>
        static void UsingConditionals()
        {
            Console.WriteLine("Using Conditionals");
            int correctNum = 10; // define an integer
            // prompt the user to enter a number in the console
            Console.Write("Guess a number : "); // using Write instead of WriteLine doesn't start a new line after the output
            // save the user input from the console
            string userGuess =  Console.ReadLine(); 
            // convert the userGuess from a string to an integer in order to compare the values
            int userNum;
            Int32.TryParse(userGuess, out userNum); //call the TryParse method and pass in the value to convert and a value to return
            // compare values
            if(userNum == correctNum)
            {
                Console.WriteLine("You guessed the correct number!"); // if values are equal 
            } 
            else 
            {
                Console.WriteLine($"You did NOT guess the correct number.\nThe correct number is {correctNum}"); // if values are not equal
            }

            Console.WriteLine("Switchcase");
            Console.WriteLine("Who is the greatest instructor of all time?"); // prompt the user to enter an instructor name
            string userInput = Console.ReadLine(); // save user input from the console
            // switch case comparing the value of the user input
            switch(userInput)
            {
                case "Autumn":
                Console.WriteLine("You entered a pretty good instructor, but not the greatest of all time"); // if the user inputs "Autumn"
                break;
                case "Kenn":
                Console.WriteLine("This instructor has moved on to Greener Mountains ;) "); // if the user inputs "Kenn"
                break;
                case "Kevin":
                Console.WriteLine("YEP! You got it ninja"); // if the user inputs "Kevin"
                break;
                default:
                Console.WriteLine("This isn't even an instructor!"); // if the user does not input one of the options above
                break;
            }
        }

        /// <summary>method <c>UsingLoops</c>
        ///
        /// - While Loop
        /// - For Loop
        /// </summary>
        static void UsingLoops()
        {
            Console.WriteLine("Using Loops");

            string userInput = ""; // define a string to hold user input from the console
            List<string> userInputList = new List<string>(); // define an empty list to hold all user input

            // prompt the user to enter anything into the console until they enter q
            // append each entry to a list
            while(userInput != "q")
            {
                userInputList.Add(userInput); // add input to array
                Console.WriteLine("Enter anything!\nEnter q to quit"); // prompt for input
                userInput = Console.ReadLine(); // keep up with input
            }

            // output all entries
            Console.WriteLine("Here's what you entered!");
            // iterate through list
            for(int i = 0; i < userInputList.Count(); i++ )
            {
                // output each element in the list
                Console.WriteLine(userInputList[i]);
            }
        }

    }
    /// <summary>class <c>PetClass</c>
    /// Class with properties Name, Age, Type (enum), and Trainned(bool)
    /// </summary>
    class PetClass  
    {
        public string Name;
        public int Age;
        public PetType Type;
        public bool Trainned;
        
    }
    /// <summary>enum <c>PetType</c>
    /// An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type
    /// </summary>
    enum PetType
    {
        Dog, Cat, Fish, Bird, Exotic
    }
}
