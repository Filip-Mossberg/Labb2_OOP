using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Labb2_OOP
{
    internal class Animal
    {
        public string AnimalType;
        public int Legs;
        public bool Fur;
        public double Weight;
        public string Sound;

        public Animal(string _AnimalType, int _Legs, bool _Fur, double _Weight, string _Sound)
        {
            this.AnimalType = _AnimalType;
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
        }
        public Animal()
        {
            this.AnimalType = "Animal";
            this.Sound = "a unknown sound";
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{AnimalType} is saying {Sound}!");
        }
        public void LargeOrSmall()
        {
            string Answer = (Weight >= 10) ? $"Thats a large {AnimalType}." : $"Thats a small {AnimalType}.";
            Console.WriteLine(Answer);
        }
        public void Insect()
        {
            string Answer = (Legs == 6) ? $"The animal is a insect" : $"The animal is not a insect";
            Console.WriteLine(Answer);
        }
    }
}
