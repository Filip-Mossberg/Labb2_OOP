using System;

namespace Labb2_OOP
{
    internal class Wolf : Animal
    {
        public int WolfPackSice;
        // Constructor that works both as a default and build contructor
        public Wolf(int _Legs = 4, bool _Fur = true, double _Weight = 27, string _Sound = "OOoooo", int _WolfPackSice = 7)
        {
            this.AnimalType = "Wolf";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.WolfPackSice = _WolfPackSice;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {AnimalType} says {Sound} to the moon!");
        }
        public void WolfPack()
        {
            string Answer = (WolfPackSice >= 5) ? $"The wolfpack is large and contain {WolfPackSice} wolfs!" : $"The wolfpack is small with {WolfPackSice} wolfs. ";
            Console.WriteLine(Answer);
        }
    }
}
