using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Labb2_OOP
{
    internal class Animal
    {
        public string Type;
        public int Legs;
        public bool Fur;
        public int Age;
        public double Weight;
        public string Sound;

        public Animal(string _Type, int _Legs, bool _Fur, int _Age, double _Weight, string _Sound)
        {
            this.Type = _Type;
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Age = _Age;
            this.Weight = _Weight;
            this.Sound = _Sound;
        }
        public Animal()
        {
            this.Type = "Animal";
            this.Sound = "a unknown sound";
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Type} is saying {Sound}!");
        }
        public void OldOrYoung()
        {
            string Answer = (Weight >= 10) ? $"Thats a large {Type}." : $"Thats a small {Type}.";
            Console.WriteLine(Answer);
        }
        public void Insect()
        {
            string Answer = (Legs == 6) ? $"The animal is a insect" : $"The animal is not a insect";
            Console.WriteLine(Answer);
        }
    }
}
