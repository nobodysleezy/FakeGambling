using System;

namespace FakeGambling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v kasinu!");
            Console.WriteLine("-----------------");

            Console.WriteLine("Co chcete hrát?");
            Console.WriteLine("1 - Tocit ovocem");
            Console.WriteLine("2 - Tocit ruletu");

            int gameChoice = Convert.ToInt32(Console.ReadLine());

            if (gameChoice == 1)
            {
                Console.WriteLine("Na co si chcete vsadit?");
                Console.WriteLine("1 - Jablka");
                Console.WriteLine("2 - Pomeranče");
                Console.WriteLine("3 - Banány");

                int fruitChoice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kolik chcete vsadit?");

                    int bet = Convert.ToInt32(Console.ReadLine());

                Random rand = new Random();
                int slot1 = rand.Next(1, 4);
                int slot2 = rand.Next(1, 4);
                int slot3 = rand.Next(1, 4);

                Console.WriteLine("[" + slot1 + "]" + "[" + slot2 + "]" + "[" + slot3 + "]");

                if (slot1 == slot2 && slot2 == slot3 && slot3 == fruitChoice)
                {
                    Console.WriteLine("Gratulujeme, vyhráli jste " + bet * 10 + "!");
                }
                else
                {
                    Console.WriteLine("Bohužel jste prohráli " + bet + ".");
                }
            }
            else if (gameChoice == 2)
            {
                Console.WriteLine("Na jaké číslo si chcete vsadit (1-20)?");
                int numberChoice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kolik chcete vsadit?");
                int bet = Convert.ToInt32(Console.ReadLine());

                Random rand = new Random();
                int rouletteNumber = rand.Next(1, 21);

                Console.WriteLine("Padlo číslo " + rouletteNumber + ".");

                if (rouletteNumber == numberChoice)
                {
                    Console.WriteLine("Gratulujeme, vyhráli jste " + bet * 20 + "!");
                }
                else
                {
                    Console.WriteLine("Bohužel jste prohráli " + bet + ".");
                }
            }
            else
            {
                Console.WriteLine("Neplatná volba.");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Děkujeme, že jste si zahráli v našem kasinu.");

            Console.ReadKey();
        }
    }
}
