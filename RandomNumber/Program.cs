using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri;
            //kui genereeritud nr on 5, programm lõpetab töö ja soovib kastajale kena päeva
            //kui midagi muud lõpetab töö

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if(myRandomNumber == 5)

                {
                    i = myRandomNumber;
                }

                Console.WriteLine("Kena päeva!");

            }


        }


    }


}
