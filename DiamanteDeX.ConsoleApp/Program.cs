namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            // Solicitar ao usuário um número inteiro ímpar
            Console.Write("Digite um número inteiro ímpar: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero % 2 != 0)
                    {
                        Console.WriteLine("Você digitou o número ímpar: " + numero);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O número não é ímpar. Tente novamente.");
                        Console.Write("Digite um número inteiro ímpar: ");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    Console.Write("Digite um número inteiro ímpar: ");
                }
            }
        }
    }
}