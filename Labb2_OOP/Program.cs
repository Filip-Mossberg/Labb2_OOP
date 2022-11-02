using System;

namespace Labb2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Lion", 4, true, 75, "RRRROOOAAAARRRR");
            animal.MakeSound();

            Bird bird = new Bird();
            bird.MakeSound();
            bird.FlyCheck();
            Console.WriteLine(bird.Weight);
        }
    }
}
