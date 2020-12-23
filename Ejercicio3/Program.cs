using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 9;
            int Y = 6;

            double N = 3.41;
            double M = 1.89;

            Console.WriteLine("El valor de X es '{0}' ", X);
            Console.WriteLine("El valor de Y es '{0}' ", Y);
            Console.WriteLine("El valor de N es '{0}' ", N);
            Console.WriteLine("El valor de M es '{0}' ", M);

            Console.WriteLine("----");

            Console.WriteLine("La suma de X e Y es '{0}'", X + Y);
            Console.WriteLine("La diferencia de X e Y es '{0}'", X - Y);
            Console.WriteLine("El producto de X e Y es '{0}'", X * Y);
            Console.WriteLine("El cociente de X e Y es '{0}'", X / Y);
            Console.WriteLine("El resto de X e Y es '{0}'", X % Y);

            Console.WriteLine("----");

            Console.WriteLine("La suma de N e M es '{0}'", N + M);
            Console.WriteLine("La diferencia de N e M es '{0}'", N - M);
            Console.WriteLine("El producto de N e M es '{0}'", N * M);
            Console.WriteLine("El cociente de N e M es '{0}'", N / M);
            Console.WriteLine("El resto de N e M es '{0}'", N % M);

            Console.WriteLine("----");

            Console.WriteLine("El doble de X es '{0}'", X * X);
            Console.WriteLine("El doble de Y es '{0}'", Y * Y);
            Console.WriteLine("El doble de Y es '{0}'", N * N);
            Console.WriteLine("El doble de Y es '{0}'", M * M);

            Console.WriteLine("----");

            Console.WriteLine("La suma de todos las variables es '{0}'", (double)X + (double)Y+ N + M);

            Console.WriteLine("----");

            Console.WriteLine("El producto de todas las variables es '{0}'", (double)X * (double)Y * N * M );


        }
    }
}
