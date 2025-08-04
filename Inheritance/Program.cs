using System;

namespace Inheritance
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
            Console.WriteLine();

            // Create instances of each class
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            Console.Write("Animal sound: ");
            animal.MakeSound();

            Console.Write("Dog sound: ");
            dog.MakeSound();

            Console.Write("Cat sound: ");
            cat.MakeSound();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}