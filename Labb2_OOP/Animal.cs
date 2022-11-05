using System;

namespace Labb2_OOP
{
    internal class Animal
    {
        public string AnimalType;
        public int Legs;
        public bool Fur;
        public double Weight;
        public string Sound;

        // Constructor that works both as a default and build contructor
        public Animal(string _AnimalType = "Animal", int _Legs = 4, bool _Fur = true, double _Weight = 2.5, string _Sound = "a unknown sound")
        {
            this.AnimalType = _AnimalType;
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{AnimalType} is making {Sound}!");
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
        public void HasFur()
        {
            string Answer = (Fur) ? $"The {AnimalType} has fur" : $"The {AnimalType} does not have fur.";
            Console.WriteLine(Answer);
        }
    }
}
