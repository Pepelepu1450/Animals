using System;

namespace Animals
{
    abstract class Animal
    {
        protected string name;

        protected string lastName;

        public string LastName {
            get => $"Mr. {lastName}"; 
            set => lastName = value;
        }

        public abstract void MakeSound();

        public string GetFullName(){
            return $"{name} {lastName}";
        }
    }
}