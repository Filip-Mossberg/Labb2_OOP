using System;

namespace Labb2_OOP
{
    internal class Bird : Animal
    {
        public bool Fly;
        // Constructor that works both as a default and build contructor
        public Bird(string _AninalType = "Bird", int _Legs = 2, double _Weight = 1.4,
            string _Sound = "Twee", bool _Fly = true) 
        {
            this.AnimalType = _AninalType;
            this.Legs = _Legs;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Fly = _Fly;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{AnimalType} is singing {Sound}!");
        }
        public void FlyCheck()
        {
            string Answer = (Fly) ? $"The {AnimalType} can fly!" : $"The {AnimalType} can not fly, maybe its a ostrich or a kiwi bird?.";
            Console.WriteLine(Answer);
        }
    }
}
