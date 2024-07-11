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
            Thread.Sleep(1000);
        }
        public void PredajOdgovoreNaPitanja()
        {
            Thread.Sleep(1000);
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write($"{ImePrezime} je predao/la ispit u: ", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine(DateTime.Now);
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------");
            IspitZavrsen?.Invoke(this);
        }
    }


}