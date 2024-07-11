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
            Console.Write("Zvono je zazvonilo. Ispit počinje: ");
            Console.WriteLine(DateTime.Now);
            Ispit?.Invoke(DateTime.Now);
        }

        // c. Kreiranje metode IspitZaprimljen
        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavač je zaprimio ispit od polaznika: {polaznik.ImePrezime}");
            Console.WriteLine("-----------------------------------------");
        }
    }
}

