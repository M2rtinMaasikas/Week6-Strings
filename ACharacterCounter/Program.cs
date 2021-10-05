using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string userLastName = Console.ReadLine();
            string fullname = $"{userFirstName}{userLastName}";
            int counter = 0;
            foreach(char character in fullname)
            {
                if (character == 'a')

            }
            {
                counter++;
            }
            Console.WriteLine($"sinu nimes on {counter} a-tähte");
        }
    }
}
