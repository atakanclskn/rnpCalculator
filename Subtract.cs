using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Çıkarma işlemini temsil eden sınıf
    class Subtract : Operator
    {
        // İki tamsayıyı çıkarır ve sonucu döndürür
        public override int Apply(int a, int b) => a - b;
    }
}
