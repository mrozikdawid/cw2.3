using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacjent pacjent1 = new Pacjent();
            pacjent1.imie = "Jacek";
            pacjent1.nazwisko = "Prociak";
            pacjent1.wzrost = 1.76;
            pacjent1.waga = 105;

            pacjent1.ObliczBmi();

            Console.ReadKey();

        }
    }
}
