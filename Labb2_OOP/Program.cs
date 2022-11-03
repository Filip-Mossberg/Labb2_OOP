using System;

namespace Labb2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound();

            Console.WriteLine("\n|----------------------------|\n");

            Bird bird = new Bird(2, 0.4, "Tweee", false);
            bird.MakeSound();
            bird.FlyCheck();
            bird.Insect();

            Console.WriteLine("\n|----------------------------|\n");

            Wolf wolf = new Wolf();
            wolf.MakeSound();
            wolf.WolfPack();

            Console.WriteLine("\n|----------------------------|\n");

            Tiger tiger = new Tiger(4, true, 60, "RRROOOAAARRRR!!", false);
            tiger.MakeSound();
            tiger.IsPlaying();

            Console.WriteLine("\n|----------------------------|\n");

            WhiteTiger whiteTiger = new WhiteTiger();
            whiteTiger.MakeSound();
            whiteTiger.LargeOrSmall();
            whiteTiger.FurColor();

            Console.WriteLine("\n|----------------------------|\n");

            TigerCub tigercub = new TigerCub(4, true, 12, "Roar", true,2);
            tigercub.MakeSound();
            tigercub.CubAge();

        }
    }
}
