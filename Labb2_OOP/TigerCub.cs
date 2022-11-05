using System;

namespace Labb2_OOP
{
    internal class TigerCub : Tiger
    {
        double Age;
        // Constructor that works both as a default and build contructor
        public TigerCub(int _Legs = 4, bool _Fur = true, double _Weight = 10, string _Sound = "RROOAARR",
            bool _Play = true, double _Age = 2)
        {
            this.AnimalType = "TigerCub";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Play = _Play;
            this.Age = _Age;
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
