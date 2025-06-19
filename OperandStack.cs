using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class OperandStack
    {
        private Stack<int> stack = new Stack<int>();
        public void Push(int value) => stack.Push(value);
        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Yeterli operand yok!");
            return stack.Pop();
        }
        public int Count => stack.Count;
        public int Peek() => stack.Peek();
    }
}
