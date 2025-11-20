using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSuma c = new CalculadoraSuma();
            double suma = c.Add(12.23, 11.3);
            Console.WriteLine("La suma total es: {0}", suma);
            Console.ReadLine();

            CalculadoraResta r = new CalculadoraResta();
            double resta = r.Res(12.4, 5);
            Console.WriteLine("La resta es: {0}", resta); 
            Console.ReadLine();
        }
    }
    class CalculadoraSuma
    {
        public double Add(double a, double b) { return a + b; }
    }

    class CalculadoraResta
    {
        public double Res(double a, double b) { return a - b; }
    }
}