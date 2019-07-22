using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUAS_PERSEGI_PANJANG_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int PANJANG = 7;
            int LEBAR   = 5;
            int LUAS;
            Console.WriteLine("LUAS PERSEGI PANJANG");
            Console.WriteLine();
            Console.WriteLine("PANJANG =" + PANJANG);
            Console.WriteLine("LEBAR   =" + LEBAR);
            LUAS = PANJANG * LEBAR;
            Console.WriteLine("LUAS    =" + LUAS);
            Console.ReadKey();
        }
    }
}
