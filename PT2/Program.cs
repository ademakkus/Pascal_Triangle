using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace PT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int satirSayisi;
            int faktoriyel = 1;
            Write("Satır numarasını giriniz : ");
            satirSayisi = int.Parse(ReadLine());
            for (int i = 1; i < satirSayisi; i++)
            {
                for (int j = 1; j < satirSayisi; j++)
                {
                    if (satirSayisi==0 || satirSayisi==1)
                    {

                        faktoriyel = 1;
                        WriteLine(faktoriyel);
                        break;
                    }
                    else
                    {
                        faktoriyel =faktoriyel* (faktoriyel - 1);
                        WriteLine(faktoriyel);
                    }
                   
                }
            }

            ReadKey();
        }
    }
}
