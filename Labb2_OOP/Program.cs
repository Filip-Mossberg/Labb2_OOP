using System;

namespace Labb2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Lion", 4, true, 15, 75, "RRRROOOAAAARRRR");
            animal.MakeSound();
            animal.OldOrYoung();
            animal.Insect();
        }
    }
}
