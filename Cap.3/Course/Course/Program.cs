using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            double n6 = 5.4;
            byte n1 = 254;
            int n2 = 1000;
            int n3 = 25555;
            long n4 = 12121515L;
            string nome = "Maria Green";
            object obj1 = "Eduardo";
            object obj2 = 2.23;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;

            Console.WriteLine(n9);
            Console.WriteLine(n8);
            Console.WriteLine(n7);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(nome);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n6);
            Console.WriteLine(n5);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
