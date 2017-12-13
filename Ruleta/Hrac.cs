using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class Hrac : Ruleta
    {

        int peniaze = 1000;

        public void StavPenazi ()
        {
            Console.WriteLine("Hrac ma : {0} dolarov", peniaze);
        }

        public int StavitNaCislo(int kolko,int nr)
        {
            //if (CisloKamDopadneGulicka)
            //{

            //}
           return peniaze = peniaze - kolko;
        }
    }
}
