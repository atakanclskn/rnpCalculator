using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Operandı temsil eden sınıf
    class Operand
    {
        // Operandın değeri
        public int Value { get; private set; }

        // Değer ile operand nesnesi oluşturur
        public Operand(int value) { Value = value; }
    }
}
