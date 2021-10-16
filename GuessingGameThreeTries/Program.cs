using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja arvab numbri;
            //kui suutis arvata õige, siis ta võitis;
            //katsete arv on 3;
            //*programm genereerib juhuslikku numbrit ühe korra.



            Random rnd = new Random();

            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Sisesta number: ");

            int i = 0;
            while (i < 3)

            {
                int myRandomNumber = rnd.Next(1, 11);

                int userPIN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");

                if (userPIN == myRandomNumber)

                {

                    Console.WriteLine("Oled võitnud!");
                    i = myRandomNumber;
                    break;

                }

                else

                {

                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                    Console.WriteLine("Arvuti võitis.");

                }
            }

        }
    }
}
    

