using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonna nime tagurpidi 
            //*eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for-tsüklit
            Console.WriteLine("Sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();
            for (int i = userFirstName.Length - 1; i >= 0; i--)
            {
                Console.Write(userFirstName[i]);
            }

        }
    }
}
