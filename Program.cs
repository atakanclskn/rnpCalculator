using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Programın başlangıç noktası
    internal class Program
    {
        // Ana giriş metodu
        static void Main(string[] args)
        {
            // Hesap makinesi arayüzünü başlatır
            var gui = new CalculatorGui();
            gui.Run();
        }
    }
}
