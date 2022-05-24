using System;
using System.Linq;

namespace Exercicio.Oito
{
    internal class Program
    {
        private static readonly char[] _vogais = new char[]
        {
            'a', 'e', 'i', 'o', 'u',
        };
        //private const char _a = 'a';
        //private const char _e = 'e';
        //private const char _i = 'i';
        //private const char _o = 'o';
        //private const char _u = 'u';

        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Digite o seu nome:");
                var nome = Console.ReadLine().ToLower();
                var count = 0;


                foreach (var letra in nome)
                {

                    if (!_vogais.Contains(letra))
                        count++;
                }

                Console.WriteLine($"Seu nome possui {count}" + $" consoantes!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
