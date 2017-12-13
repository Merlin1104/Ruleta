using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class Ruleta
    {
        

        Random randomGen = new Random();


        string[] farba = new string[] { "cervena", "cerna" };
        public Farba[] PoleF = new Farba[1];

        public void Uvitanie()
        {
            Console.WriteLine("Dobry den, mozete si vsadit na cislo, farbu alebo parne / neparne cislo");
        }

        public void CisloKamDopadneGulicka()
        {


            int cislo = randomGen.Next(0, 37);
            int[] hernePole = new int[] { cislo };

            foreach (int nr in hernePole)
            {
                Console.WriteLine(nr);
            }

            
            for (int i = 0; i < PoleF.Length; i++)
            {
                
                if (cislo % 2 == 0 && cislo != 0)
                {
                    Farba F;
                    F.FarbaCisla = farba[randomGen.Next(farba.Length)];
                    PoleF[i] = F;
                    Console.WriteLine("Cislo je parne(sude)");
                }
                else if (cislo == 0)
                {
                    Console.WriteLine("Cislo je 0");
                }

                else
                {
                    Farba F;
                    F.FarbaCisla = farba[randomGen.Next(farba.Length)];
                    PoleF[i] = F;
                    Console.WriteLine("Cislo je neparne(liche)");
                }
                



            }
        }

        

        


    }
}
