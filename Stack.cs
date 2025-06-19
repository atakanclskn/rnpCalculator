using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Tamsayılar için yığın (stack) sınıfı
    class Stack
    {
        // Yığın verilerini tutan özel Stack nesnesi
        private Stack<int> stack = new Stack<int>();

        // Yığına eleman ekler
        public void Push(int value) => stack.Push(value);

        // Yığından eleman çıkarır ve döndürür
        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Yeterli operand yok!");
            return stack.Pop();
        }

        // Yığındaki eleman sayısını döndürür
        public int Count => stack.Count;

        // Yığının en üstündeki elemanı döndürür (çıkarmaz)
        public int Peek() => stack.Peek();

        // Yığındaki tüm elemanları (üstten alta) döndürür
        public IEnumerable<int> GetStackContents()
        {
            return stack.Reverse();
        }
    }
}
