using System;

namespace Labb2_OOP
{
    internal class WhiteTiger : Tiger
    {
        // Constructor where you can create new whitetigers
        public WhiteTiger(int _Legs, bool _Fur, double _Weight, string _Sound, bool _Play) : base(_Legs, _Fur, _Weight, _Sound, _Play)
        {
            this.AnimalType = "WhiteTiger";
        }
        // Default Constructor For WhiteTiger
        public WhiteTiger()
        {
            this.AnimalType = "WhiteTiger";
            this.Legs = 4;
            this.Fur = true;
            this.Weight = 35;
            this.Sound = "RRRAAAWWWRR";
            this.Play = false;
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
