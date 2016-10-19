using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Konto
    {
        public double saldoPoczatkowe;
        public double saldoKoncowe;
        public string PrzelewMiedzyKontami(double saldoPoczatkowe, double ile)
    {
        saldoKoncowe=ile-saldoPoczatkowe;
        return "Przelano! zostalo ci: "+ saldoKoncowe;
    }
    }
}
