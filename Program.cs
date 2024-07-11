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

            predavac.ZvoniZvono();
            Console.WriteLine("");

            foreach (var polaznik in polaznici)
            {
                polaznik.OdgovoriNaPitanja(DateTime.Now);
                Console.WriteLine("------------------------------------------------------------------");
            }
           
            Polaznik polaznikZaPredaju = DohvatiRandomPolaznika(polaznici);

            polaznikZaPredaju.PredajOdgovoreNaPitanja();
            predavac.IspitZaprimljen(polaznikZaPredaju);

            polaznikZaPredaju.IspitZavrsen += predavac.IspitZaprimljen;

            predavac.Ispit += polaznikZaPredaju.OdgovoriNaPitanja;

            Console.ReadKey();
        }
        public static Polaznik DohvatiRandomPolaznika(List<Polaznik> polaznici)
        {
            Random random = new Random();
            int nasumicni = random.Next(polaznici.Count);
            return polaznici[nasumicni];
        }

           
     }

 }
