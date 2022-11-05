using System;

namespace Labb2_OOP
{
    internal class Tiger : Animal
    {
        public bool Play;
        // Constructor that works both as a default and build contructor
        public Tiger(int _Legs = 4, bool _Fur = true, double _Weight = 62,
            string _Sound  = "RRRRAAAWWWRRR", bool _Play = true)
        {
            this.AnimalType = "Tiger";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Play = _Play;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {AnimalType} says {Sound}!!!!!");
        }
        public void IsPlaying()
        {
            string Answer = (Play) ? $"The {AnimalType} is palying!" : $"The {AnimalType} is sleeping?.";
            Console.WriteLine(Answer);
        }
        public virtual void FurColor()
        {
            Console.WriteLine($"The {AnimalType} color is orange.");
        }
    }
}
