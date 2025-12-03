// Create a base class Animal with a virtual method Sound(). Derive classes
//     Dog and Cat and override the Sound() method in each to print unique
// messages. Demonstrate runtime polymorphism.



using System;

    class Animal{
        public virtual void MakeSound(){     //virtual modifier allows to over the method in the child class
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program4B4
    {
        public static void Run()
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound(); 
            myDog.MakeSound();    
            myCat.MakeSound();   
        }
    }
