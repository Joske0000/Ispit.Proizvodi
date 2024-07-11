using System;
using System.Threading;

namespace Ispit.Proizvodi 
{
public class Polaznik
    {
       
        public string ImePrezime { get; set; }

        public delegate void PredajIspit(Polaznik polaznik);

        public event PredajIspit IspitZavrsen;

      
        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"Polaznik: {ImePrezime} je započeo ispit {vrijeme_pocetka}");
            Thread.Sleep(2000);
        }


        public void PredajOdgovoreNaPitanja()
        {
            Thread.Sleep(5000);
            Console.Write($"{ImePrezime} je predao odgovore u: ");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-----------------------------------------");
            IspitZavrsen?.Invoke(this);
        }
    }
}