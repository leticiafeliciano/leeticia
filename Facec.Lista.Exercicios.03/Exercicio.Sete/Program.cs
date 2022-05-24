using System;

namespace Exercicio.Sete
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Informe seu nome: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe sua data " + "nascimento no fomato dd/MM/yyyy");
                // DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

                var dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if (idade >= 60)
                return $"Olá {nome}, esta na faixa etário idoso!";
            else if (idade >= 23 && idade <= 59)
                return $"Olá {nome}, esta na faixa etária Adulto";

            return $"Olá {nome}, esta na faixa etária Jovem";
        }
    }
}
