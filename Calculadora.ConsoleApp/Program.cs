namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            Console.WriteLine("Digite o primeiro número: ");
            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);
            
            Console.WriteLine("Digite o segundo número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);


            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine(resultado);

            Console.ReadLine();

        }
    }
}
