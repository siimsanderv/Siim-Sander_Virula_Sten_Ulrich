using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("See on allahindluse arvutamise programm, sisesta summa: ");
            int hind = int.Parse(Console.ReadLine());
            if (hind > 49 && hind < 250)
            {
                Console.WriteLine($"Tavaklient:\nSumma: {hind} eurot\nAllahindlus: 10%\nTasuda: {hind * 0.9} eurot");
                Console.WriteLine($"\nPüsiklient:\nSumma: {hind} eurot\nAllahindlus: 20%\nTasuda: {hind * 0.8} eurot");
            }
            if (hind > 249 && hind < 350)
            {
                Console.WriteLine($"Tavaklient:\nSumma: {hind} eurot\nAllahindlus: 20%\nTasuda: {hind * 0.8} eurot");
                Console.WriteLine($"\nPüsiklient:\nSumma: {hind} eurot\nAllahindlus: 30%\nTasuda: {hind * 0.7} eurot");
            }
            if (hind > 349)
            {
                Console.WriteLine($"Tavaklient:\nSumma: {hind} eurot\nAllahindlus: 30%\nTasuda: {hind * 0.7} eurot");
                Console.WriteLine($"\nPüsiklient:\nSumma: {hind} eurot\nAllahindlus: 40%\nTasuda: {hind * 0.6} eurot");
            }
            Console.ReadKey();

        }
    }
}
