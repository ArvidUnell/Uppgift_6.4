using System;
namespace Uppgift_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potens(3,2));
            Console.WriteLine(Potens(6.2,4));
        }
        /// <summary>
        /// Beräknar en potens med heltalsexponent
        /// </summary>
        /// <param name="bas">Potensens bas</param>
        /// <param name="exponent">Potensens exponent</param>
        /// <returns>Potensens värde</returns>
        static double Potens(double bas, int exponent)
        {
            return Math.Pow(bas, exponent);
        }
    }
}