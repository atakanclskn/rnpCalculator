using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class CalculatorGui
    {
        private const string LogFilePath = "error_log.txt";

        public void Run()
        {
            var calculator = new Calculator();

            while (true)
            {
                Console.Write("RPN İfadesi girin (çıkmak için 'exit'): ");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "exit") break;

                try
                {
                    int result = calculator.Evaluate(input);
                    Console.WriteLine($"Sonuç: {result}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}\n");
                    File.AppendAllText(LogFilePath, $"[{DateTime.Now}] {ex.Message}\n");
                }
            }
        }
    }
}
