using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    internal class Predavac
    {
        
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.Write("Brrrrrrrr.......Zvono je zazvonilo. Ispit počinje: ");
            Console.WriteLine("");
            Ispit?.Invoke(DateTime.Now);
        }
    
        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Predavač je zaprimio ispit od polaznika: {polaznik.ImePrezime}", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
        }
    }
}

