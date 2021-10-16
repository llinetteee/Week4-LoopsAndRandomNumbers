using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kaustaja arvan numbri;
            //kui suutis arvaa õige, siis ta võitis;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            Console.WriteLine("Sisesta number: ");

            while (loopActive) 

            {

                int RandomNumber = rnd.Next(1, 11);

                int userPIN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Juhuslik number on {RandomNumber}");

                if (userPIN == RandomNumber)
                {

                    Console.WriteLine("Oled võitnud!!!!");
                    i = RandomNumber;
                    loopActive = false;

                }

                else

                {

                    i++;
                    Console.WriteLine("Arvuti võitis :( ");


                }
            }
        }
    }

}
