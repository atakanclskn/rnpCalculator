using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Tüm operatörler için soyut temel sınıf
    abstract class Operator
    {
        // Operatörün uygulama metodunu tanımlar
        public abstract int Apply(int a, int b);
    }
}
