using System;
using System.Collections.Generic;
using System.Text;

namespace IPA_Laboratorinis_3_4
{
    class Studentas
    {

        public string vardas;
        public string pavarde;
        public int[] nd_rez;
        public int egz_rez;
        public double galutinis_vid;
        public double galutinis_med;


        public Studentas(string vardas, string pavarde, int[] nd_rez, int egz_rez)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.nd_rez = nd_rez;
            this.egz_rez = egz_rez;

            double a = 0;

            for (int i = 0; i < nd_rez.Length; i++)
            {
                a += nd_rez[i];
            }

            a = a / nd_rez.Length;

            a = a * 0.3 + egz_rez * 0.7;

            this.galutinis_vid = a;

            Array.Sort(nd_rez);

            if (nd_rez.Length % 2 == 0)
            {
                a = (nd_rez[(nd_rez.Length/2)-1] + nd_rez[(nd_rez.Length / 2)]) / 2;
            }
            else
            {
                a = nd_rez[nd_rez.Length/2];
            }

            
            a = a * 0.3 + egz_rez * 0.7;

            this.galutinis_med = a;

        }

      
    }
}