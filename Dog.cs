using System;

namespace Animals
{
   class Dog : Animal
    {
        public Dog(string lastName){
            this.name = "Dog";
            this.lastName = lastName;
        }
        public override void MakeSound(){
            Console.WriteLine($"{this.name} goes Woof");
        }
    }
}