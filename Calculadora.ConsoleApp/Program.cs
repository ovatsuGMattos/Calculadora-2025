using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static bool Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("----------------------------");

            Console.WriteLine("1-Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("S- Sair");

            Console.WriteLine("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();

            //.ToUpper transforma tudo em maiusculo

            //estrutura de decisão (se/senão)

            if (opcao == "S")
            {
            return;
            }

            Console.WriteLine("Digite o primeiro número: ");
            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);
            
            Console.WriteLine("Digite o segundo número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;

            //se/senao/ senao se
            if (opcao == "1") ;
            {
                 resultado = primeiroNumero + segundoNumero;
            }
            elseif (opcao == "2");
            {
                resultado = primeiroNumero - segundoNumero;
            }
            Console.WriteLine(resultado);

            Console.ReadLine();

        }
    }
}
