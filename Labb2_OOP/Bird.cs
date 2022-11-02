using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Labb2_OOP
{
    internal class Bird : Animal
    {
        public bool Fly;
        // Constructor where you can create new birds
        public Bird(int _Legs, double _Weight, string _Sound, bool _Fly) 
        {
            this.AnimalType = "Bird";
            this.Legs = _Legs;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Fly = _Fly;
        }
        // Default Constructor For Bird
        public Bird()
        {
            this.AnimalType = "Bird";
            this.Legs = 2;
            this.Weight = 1.4;
            this.Sound = "Scuee";
            this.Fly = true;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{AnimalType} is singing {Sound}!");
        }
        public void FlyCheck()
        {
            string Answer = (Weight >= 10) ? $"The {AnimalType} can not fly, maybe its a ostrich or a kiwi bird?." : $"The {AnimalType} can fly!";
            Console.WriteLine(Answer);
        }
    }
}
