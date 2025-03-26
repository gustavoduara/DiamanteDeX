namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            // Solicitar ao usuário um número inteiro ímpar
            Console.WriteLine("Digite um número inteiro ímpar: ");

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
                        Console.Write("Digite um número ímpar: ");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro ímpar.");
                }
            }

            // Desenhar o diamante
            MostrarDiamante(numero);

            Console.Write("Deseja continuar? (S/N): ");
            while (Console.ReadLine()!.ToUpper() == "S");
        }

        static void MostrarDiamante(int tamanho)
        {
            for (int i = 0; i <= tamanho; i += 2)
            {
                Console.WriteLine(new string(' ', (tamanho - i) / 2) + new string('X', i));
            }
            for (int i = tamanho - 2; i > 0; i -= 2)
            {
                Console.WriteLine(new string(' ', (tamanho - i) / 2) + new string('X', i));
            }
        }
    }
}