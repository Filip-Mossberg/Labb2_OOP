using System;

namespace Labb2_OOP
{
    internal class WhiteTiger : Tiger
    {
        // Constructor that works both as a default and build contructor
        public WhiteTiger(int _Legs = 4, bool _Fur = true, double _Weight = 45, string _Sound = "RRRRAAAAWWWRRR", bool _Play = false) 
        {
            this.AnimalType = "WhiteTiger";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Play = _Play;
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
        public override void FurColor()
        {
            Console.WriteLine($"The {AnimalType} color is white.");
        }
    }
}
