using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saida de dados (Console)
            
            // Imprimindo texto
            Console.Write("Bom dia!");//Sem Quebra de Linha
            Console.WriteLine("Boa Tarde!");//Com quebra de linha
            Console.WriteLine("Boa noite!");
            Console.WriteLine("--------------------------");
            
            //Imprimindo variáveis 
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);

            //Place Holders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.",nome,idade,saldo);
            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            //Concatenação de Strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}
