using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Toplama işlemini temsil eden sınıf
    class Add : Operator
    {
        // İki tamsayıyı toplar ve sonucu döndürür
        public override int Apply(int a, int b) => a + b;
    }
}
