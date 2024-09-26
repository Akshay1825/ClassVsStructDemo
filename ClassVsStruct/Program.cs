using ClassVsStruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1].Memory Allocation\nClass --> Heap\nStruct --> Stack");
            // Difference 1: Memory Allocation

            Human human = new Human("Ram",25);
            Human tempVariable1 = human;

            HumanStruct humanStruct = new HumanStruct("Sham",30);
            HumanStruct tempVariable2 = humanStruct;

            Console.WriteLine($"Human 1: {human.Name},{human.Age}");
            Console.WriteLine($"Copy of Human 1: {tempVariable1.Name},{tempVariable1.Age}");

            Console.WriteLine($"Struct --> Human 1 : {humanStruct.Name}, {humanStruct.Age}");
            Console.WriteLine($"Struct --> Copy of Human 1: {tempVariable2.Name}, {tempVariable2.Age}");

  
            Console.WriteLine("\n2].Reference type and Value type");
            // Difference 2: Reference vs Value Type
            // Here we will modify the names
            // In Class,original objects gets updated hence called reference type
            // In Struct,original object remains same hence called value type

            tempVariable1.Name = "Sachin"; 
            tempVariable2.Name = "Nitin"; 

            Console.WriteLine("Modified Values");
            Console.WriteLine($"Human 1: {human.Name},{human.Age}");
            Console.WriteLine($"Copy of Human 1: {tempVariable1.Name},{tempVariable1.Age}");

            Console.WriteLine($"Struct --> Human 1: {humanStruct.Name},{humanStruct.Age}");
            Console.WriteLine($"Struct --> Copy of Human 1: {tempVariable2.Name},{tempVariable2.Age}");


            Console.WriteLine("\n3].Inheritance");
            // Difference 3: Inheritance 
            // Class supports Inheritance but Struct dont support Inheritance

            //We have used base keyword in Man class which will be using constructor chaining concept.
            //So,Inheritance is initiated in class
            Man man = new Man("Yogesh",10,"5th Class");
            man.PrintDetails();

            //We cant use the below statement as it will throw error
            //ManStruct manStruct = new ManStruct();


            Console.WriteLine("\n4].Default Constructor");
            // Difference 4: Default Constructors
            // Classes can have a parameterless constructor
            // Structs cannot have parameterless constructors

            Human human2 = new Human();
            Console.WriteLine($"Human : {human2.Name},{human2.Age}");

            HumanStruct humanStruct2 = new HumanStruct();
            Console.WriteLine($"Struct Human : {humanStruct2.Name},{humanStruct2.Age}");

            
            Console.WriteLine("\n5].Null-ability");
            // Difference 5: Null-ability
            // Classes can be null
            // Structs cannot be null

            Human nullClass = null;  
            if (nullClass == null)
            {
                Console.WriteLine("Class object is null");
            }

            //If we Uncomment the below part it will show error
            //HumanStruct nullStruct = null; 
            //if (nullStruct == null)
            //{
            //    Console.WriteLine("Struct object is null");
            //}
        }
    }
}


