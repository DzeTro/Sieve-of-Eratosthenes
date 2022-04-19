using System;

namespace SiebDesErstosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die obere Grenze ein: ");
            int UpperBound = int.Parse(Console.ReadLine());
            bool[] Tagged = new bool[UpperBound + 1];

           
            ArrayFalsInitialsiert(Tagged);

            for (int i = 2; i < Math.Ceiling(Math.Sqrt(UpperBound)); i++)
            {
                if (!Tagged[i])
                {
                    int j = i;

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
