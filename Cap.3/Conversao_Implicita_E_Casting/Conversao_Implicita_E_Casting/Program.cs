using System;

namespace Conversao_Implicita_E_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            int a = 5;
            int b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);

        }
    }
}
