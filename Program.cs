using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    public delegate void PocniPisatiIspit(DateTime datumIVrijeme);
    internal class Program
    {
        static void Main(string[] args)
        {

            Predavac predavac = new Predavac();

            List<Polaznik> polaznici = new List<Polaznik>
             {
                new Polaznik { ImePrezime = "Marko Marković" },
                new Polaznik { ImePrezime = "Ana Anić" },
                new Polaznik { ImePrezime = "Petar Petrović" },
                new Polaznik { ImePrezime = "Jelena Jelić" }
             };

            foreach (var polaznik in polaznici)
            {
                predavac.Ispit += polaznik.OdgovoriNaPitanja;
                polaznik.IspitZavrsen += predavac.IspitZaprimljen;
            }

            predavac.ZvoniZvono();

            Random random = new Random();
            int odabraniPolaznik = random.Next(polaznici.Count);
            polaznici[odabraniPolaznik].PredajOdgovoreNaPitanja();

            foreach (var polaznik in polaznici)
            {
                predavac.Ispit -= polaznik.OdgovoriNaPitanja;
                polaznik.IspitZavrsen -= predavac.IspitZaprimljen;
            }

            Console.ReadKey();
        }
    }
}
