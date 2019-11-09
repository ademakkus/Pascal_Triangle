using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace PT3
{
    class Program
    {
        static void Main(string[] args)
        {

            int satirSayisi;
            int diziEleman;
            int faktoriyel = 1;
            int sonuc;
            Write("Satır numarasını giriniz : ");
            satirSayisi = int.Parse(ReadLine());
            int x, y;
            x = satirSayisi;
            for (int i = 0; i <= satirSayisi; i++)
            {
                y = 1;
                y += i;
              SetCursorPosition(x,y);
                for (int j = 0; j <= i; j++)
                {

                    sonuc = FaktoriyelHesapla(i) / (FaktoriyelHesapla(j) * FaktoriyelHesapla(i - j));

                    Write(sonuc);

                    Write(" ");
                }

                x--;
                
                
                WriteLine();

            }
            ReadKey();


        }

        private static int FaktoriyelHesapla(int satirSayisi)
        {
            //  return (satirSayisi == 0 || satirSayisi == 1) ? 1 : ( sabit * FaktoriyelHesapla(satirSayisi - 1));
            return (satirSayisi <= 1) ? 1 : satirSayisi * FaktoriyelHesapla(satirSayisi - 1);

        }
    }
}
