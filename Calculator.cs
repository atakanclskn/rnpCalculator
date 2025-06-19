using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // RPN hesaplamalarını yapan sınıf
    class Calculator
    {
        // Girilen RPN ifadesini değerlendirir ve sonucu döndürür
        public int Evaluate(string input)
        {
            var operandStack = new Stack<int>();
            // Girdiyi boşluklara göre ayır
            string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                // Token bir sayı ise yığına ekle
                if (int.TryParse(token, out int number))
                {
                    operandStack.Push(number);
                }
                else
                {
                    // Yeterli operand yoksa hata fırlat
                    if (operandStack.Count < 2)
                        throw new InvalidOperationException("Yeterli operand yok!");

                    // İki operandı yığından çıkar
                    int right = operandStack.Pop();
                    int left = operandStack.Pop();

                    // Operatörü al ve işlemi uygula
                    Operator op = GetOperator(token);
                    int result = op.Apply(left, right);
                    // Sonucu tekrar yığına ekle
                    operandStack.Push(result);
                }

                // Her adımda yığının mevcut durumunu ekrana yazdır
                Console.WriteLine("{0,-10} | [{1}]", token, string.Join(", ", operandStack.Reverse()));
            }

            // Sonuç olarak yığında tek bir değer kalmalı
            if (operandStack.Count != 1)
                throw new Exception("Geçersiz ifade: operand veya operatör eksik/fazla olabilir.");

            return operandStack.Pop();
        }

        // Operatör sembolüne göre ilgili operatör nesnesini döndürür
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
