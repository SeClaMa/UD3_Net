using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 2;
            int B = 4;
            int C = 8;
            int D = 16;

            Console.WriteLine("A =|{0}| B =|{1}| C = |{2}| D = |{3}| ", A, B, C, D);

            Console.WriteLine("B toma de C {0}", B += C);
            Console.WriteLine("C toma de A {0}", C += A);
            Console.WriteLine("A toma de D {0}", A += D);
            Console.WriteLine("D toma de B {0}", D += B);
        }
    }
}
