using System;

namespace Labb2_OOP
{
    internal class Wolf : Animal
    {
        public int WolfPackSice;
        // Constructor where you can create new wolfs
        public Wolf(int _Legs, bool _Fur, double _Weight, string _Sound, int _WolfPackSice)
        {
            this.AnimalType = "Wolf";
            this.Legs = _Legs;
            this.Fur = _Fur;
            this.Weight = _Weight;
            this.Sound = _Sound;
            this.WolfPackSice = _WolfPackSice;
        }
        // Default Constructor For Wolf
        public Wolf()
        {
            this.AnimalType = "Wolf";
            this.Legs = 4;
            this.Fur = true;
            this.Weight = 26;
            this.Sound = "OOOooooo";
            this.WolfPackSice = 7;
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
