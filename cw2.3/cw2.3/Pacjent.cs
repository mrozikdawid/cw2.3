using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._3
{
    class Pacjent
    {
        public string imie;
        public string nazwisko;
        public double wzrost;
        public double waga;


        public void ObliczBmi()
        {
            Console.WriteLine((waga)/(wzrost*wzrost));
        }

    }
}
