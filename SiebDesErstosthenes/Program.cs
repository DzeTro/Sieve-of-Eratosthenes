using System;

namespace SiebDesErstosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die obere Grenze ein: ");
            int UpperBound = int.Parse(Console.ReadLine()); // Zahl, bis z der gesucht werden soll, eingeben
            bool[] Tagged = new bool[UpperBound + 1]; // Array zur Speicherung ob die zum Index passende Zahl gestrichen wurde

           
            ArrayFalsInitialsiert(Tagged);

            // alle Zahlen bis zur Wutzel der oberen zahl durchlaufen
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(UpperBound)); i++)
            {
                if (!Tagged[i])
                {
                    int j = i;

                    // alle Vielfachen der Zahl i, angefangen von ihrer Quadratzahl, durchstreichen
                    while (j * i <= UpperBound)
                    {
                        Tagged[j * i] = true;
                        j++;
                    }
                }
            }
            for (int i = 0; i < Tagged.Length; i++)
            {
                if (!Tagged[i])
                    Console.WriteLine(i.ToString() + "");
                {

                }
            }
        }

        private static void ArrayFalsInitialsiert(bool[] Tagged)
        {
            for (int i = 0; i < Tagged.Length; i++)
            {
                Tagged[i] = false;
            }
        }
    }
}
