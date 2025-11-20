using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSuma s = new CalculadoraSuma();
            int sumaTotal = s.Suma(12, 5);
            Console.WriteLine("La suma total es: {0}", sumaTotal); Console.ReadLine();

            CalculadoraResta r = new CalculadoraResta();
            int restaTotal = r.Resta(20, 4);
            Console.WriteLine("La resta es: {0}", restaTotal); Console.ReadLine(); 
        }
    }
    class CalculadoraSuma
    {
        public int Suma(int a, int b) { return a + b; }
    }

    class CalculadoraResta
    {
        public int Resta(int a, int b) { return a - b; }
    }
}