using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada pin koodi;
            //programm võrdleb sisestatud pin koodi arvuga 1234;
            //kui sisestatud pin kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud pin kood on midagi muud, siis konsool kuvab "vale pin, proovi uuesti";
            //kasutajal on kolm katset.

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }

            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
