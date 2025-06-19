using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class Calculator
    {
        private readonly Stack operandStack = new Stack();

        public int Evaluate(string input)
        {
            string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    operandStack.Push(number);
                }
                else
                {
                    Operator op = GetOperator(token);
                    int b = operandStack.Pop();
                    int a = operandStack.Pop();
                    int result = op.Apply(a, b);
                    operandStack.Push(result);
                }
            }

            if (operandStack.Count != 1)
                throw new Exception("Geçersiz ifade: operand veya operatör eksik/fazla olabilir.");

            return operandStack.Pop();
        }

        private Operator GetOperator(string symbol)
        {
            switch (symbol)
            {
                case "+": return new Add();
                case "-": return new Subtract();
                case "*": return new Multiply();
                case "/": return new Divide();
                default: throw new Exception($"Tanımsız operatör: {symbol}");
            }
        }
    }
}
