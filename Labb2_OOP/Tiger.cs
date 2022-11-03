using System;

namespace Labb2_OOP
{
    internal class Tiger : Animal
    {
        public bool Play;
        // Constructor where you can create new tigers
        public Tiger(int _Legs, bool _Fur, double _Weight, string _Sound, bool _Play)
        {
            this.AnimalType = "Tiger";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.Play = _Play;
        }
        // Default Constructor For Tiger
        public Tiger()
        {
            this.AnimalType = "Tiger";
            this.Legs = 4;
            this.Fur = true;
            this.Weight = 35;
            this.Sound = "RRRAAAWWWRR";
            this.Play = true;
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
