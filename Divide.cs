using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Bölme işlemini temsil eden sınıf
    class Divide : Operator
    {
        // İki tamsayıyı böler ve sonucu döndürür
        public override int Apply(int a, int b)
        {
            // Sıfıra bölme kontrolü
            if (b == 0)
                throw new DivideByZeroException("Sıfıra bölme hatası!");
            return a / b;
        }
    }
}
