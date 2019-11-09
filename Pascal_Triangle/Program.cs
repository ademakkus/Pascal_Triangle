using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int satirSayisi;
            Write("Satır numarasını giriniz : ");
            satirSayisi = int.Parse(ReadLine());
            PascaUcgeniOlustur(satirSayisi);
            ReadKey();
        }

        private static void PascaUcgeniOlustur(int satirSayisi)
        {
            //int Faktoriyel = 1;
            int sonuc = 1;
            for (int i = 0; i <satirSayisi; i++)
            {
                sonuc=Faktoriyel(satirSayisi) / (Faktoriyel(satirSayisi - i) * Faktoriyel(i));
                Write(sonuc);
            }

            
        }

        private static int Faktoriyel(int satirSayisi)
        {
            if (satirSayisi==0 || satirSayisi==1 )
            {
                return 1;
          
            }
            else
            {
                return  Faktoriyel(satirSayisi) * Faktoriyel(satirSayisi - 1);
            }
        }


    }
}
