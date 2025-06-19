using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class Calculator
    {
        public int Evaluate(string input)
        {
            var operandStack = new Stack<int>();
            string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    operandStack.Push(number);
                }
                else
                {
                    if (operandStack.Count < 2)
                        throw new InvalidOperationException("Yeterli operand yok!");

                    int right = operandStack.Pop();
                    int left = operandStack.Pop();

                    Operator op = GetOperator(token);
                    int result = op.Apply(left, right);
                    operandStack.Push(result);
                }

                // Her adımda yığın durumunu yazdırma:
                Console.WriteLine("{0,-10} | [{1}]", token, string.Join(", ", operandStack.Reverse()));
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
