using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("sisesta oma nimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine($"sinu nimi on {userFirstName} sümbolit pikk.");



        }
    }
}
