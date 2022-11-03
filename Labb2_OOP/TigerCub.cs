using System;

namespace Labb2_OOP
{
    internal class TigerCub : Tiger
    {
        double Age;
        // Constructor where you can create new tigercubs
        public TigerCub(int _Legs, bool _Fur, double _Weight, string _Sound, bool _Play, double _Age) : base(_Legs, _Fur, _Weight, _Sound, _Play)
        {
            this.AnimalType = "TigerCub";
        }
        // Default Constructor For TigerCub
        public TigerCub()
        {
            this.AnimalType = "TigerCub";
            this.Legs = 4;
            this.Fur = true;
            this.Weight = 10;
            this.Sound = "RRRAAAWWWRR";
            this.Play = true;
            this.Age = 2;
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
        public void CubAge()
        {
            string Answer = (Age <= 3) ? $"It's a young {AnimalType}!" : $"It's a bigger {AnimalType}!";
            Console.WriteLine(Answer);
        }
    }
}
