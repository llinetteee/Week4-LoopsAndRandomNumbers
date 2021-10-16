using System;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada pin koodi;
            //programm võrdleb sisestatud pin koodi arvuga 1234;
            //kui sisestatud pin kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud pin kood on midagi muud, siis konsool kuvab "vale pin, proovi uuesti";
            //Katsete arv on piiramatu.


            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; //i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN- koodi {i} korda sisestanud.");
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}