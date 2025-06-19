using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Hesap makinesi arayüzünü yöneten sınıf
    class CalculatorGui
    {
        // Hata kayıtlarının tutulduğu dosya yolu
        private const string LogFilePath = "error_log.txt";

        // Arayüzü başlatan ve kullanıcıdan giriş alan ana metot
        public void Run()
        {
            var calculator = new Calculator();

            while (true)
            {
                // Kullanıcıdan RPN ifadesi alınır
                Console.Write("RPN İfadesi girin (çıkmak için 'exit'): ");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "exit") break;

                try
                {
                    // İfade hesaplanır ve sonuç ekrana yazdırılır
                    int result = calculator.Evaluate(input);
                    Console.WriteLine($"Sonuç: {result}\n");
                }
                catch (Exception ex)
                {
                    // Hata mesajı ekrana ve log dosyasına yazılır
                    Console.WriteLine($"Hata: {ex.Message}\n");
                    File.AppendAllText(LogFilePath, $"[{DateTime.Now}] {ex.Message}\n");
                }
            }
        }
    }
}
