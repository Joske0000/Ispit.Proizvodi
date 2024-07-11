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

            List<Polaznik> polaznici = new List<Polaznik>();
            polaznici.Add(new Polaznik { ImePrezime = "Marko Marković" });
            polaznici.Add(new Polaznik { ImePrezime = "Ana Anić" });
            polaznici.Add(new Polaznik { ImePrezime = "Petar Petrović" });
            polaznici.Add(new Polaznik { ImePrezime = "Jelena Jelić" });
            
            predavac.ZvoniZvono();
            Console.WriteLine("");

            foreach (var polaznik in polaznici)
            {
                polaznik.OdgovoriNaPitanja(DateTime.Now);
                Console.WriteLine("------------------------------------------------------------------");
            }
            

            Random random = new Random();
            int index = random.Next(polaznici.Count);
            Polaznik polaznikZaPredaju = polaznici[index];

            
            polaznikZaPredaju.IspitZavrsen += predavac.IspitZaprimljen;

            predavac.Ispit += polaznikZaPredaju.OdgovoriNaPitanja;
            
           
            polaznikZaPredaju.PredajOdgovoreNaPitanja(); 


            Console.ReadKey();
        }
        
    }
}
