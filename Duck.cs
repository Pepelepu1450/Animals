using System;

namespace Animals
{
   class Duck : Animal
    {
        public Duck(string lastName){
            this.name = "Duck";
            this.lastName = lastName;
        }
        public override void MakeSound(){
            Console.WriteLine($"{this.name} goes Quack World!");
        }
    }
}