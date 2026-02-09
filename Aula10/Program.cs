namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            Console.WriteLine("\nCalculadora Simples\n");

            Console.WriteLine("X = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Escolha o tipo de operacao (+, -, *, /...etc.)

            Console.WriteLine("\nEscolha uma operacao: ");
            Console.WriteLine("1- Adicao (+)");
            Console.WriteLine("2- Subtracao (-)");
            Console.WriteLine("3- Multiplicacao (*)");
            Console.WriteLine("4- Divisao (/)");
            Console.WriteLine("5- Sair");
            Console.WriteLine("Escolha a operacao desejada: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                double resultado = x + y;
                Console.WriteLine($"Resultado: X + Y = {resultado}");
            } else if (escolha == 2)
            {
                double resultado = x - y;
                Console.WriteLine($"Resultado: X - Y = {resultado}");
            } else if (escolha == 3)
            {
                double resultado = x * y;
                Console.WriteLine($"Resultado: X x Y = {resultado}");
            } else if (escolha == 4)
            {
                if (y != 0)
                {
                    double resultado = x / y;
                    Console.WriteLine($"Resultado: X / Y = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro, nao tem como dividir por zero.");
                }
            }
            else if (escolha == 5)
            {
                Console.WriteLine("Saindo da aplicacao.");
                varContinue = false;
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        } 
    }
}