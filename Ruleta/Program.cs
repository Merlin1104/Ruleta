using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Hrac Jozo = new Hrac();
            Jozo.StavPenazi();
            Jozo.StavitNaCislo(100,8);
            Jozo.StavPenazi();

            Ruleta R = new Ruleta();
            R.Uvitanie();
            R.CisloKamDopadneGulicka();


            //foreach (Farba F1 in R.PoleF)
            //{
            //    Console.WriteLine(F1.FarbaCisla);
            //}
            /*
            Vysledok v = new Vysledok();
            v.VypisVysledok();
            */
            Console.ReadLine();
        }
    }
}
