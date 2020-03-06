using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("Whit Shoes");

            duck.MakeSound();
            Console.WriteLine(duck.GetFullName());

            Console.WriteLine(duck.LastName);
            duck.LastName = "Donald";
            Console.WriteLine(duck.LastName);
            Console.WriteLine(duck.GetFullName());

            Animal dog = new Dog ("Barie");
            Animal duck2 = new Duck("McDonald");

            Animal[] pets = new Animal[2];
            pets[0] = dog;
            pets[1] = duck2;
        } 
    }
}
