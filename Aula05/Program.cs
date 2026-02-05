namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------Calculadora Simples------");

        Console.WriteLine("Digite numero 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite numero 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        int soma = number1 + number2;
        int sub = number1 - number2;
        int multi = number1 * number2;
        int div = number1 / number2;
        int resto = number1 % number2;

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Substracao: " + sub);
        Console.WriteLine("Multiplicacao: " + multi);
        Console.WriteLine("Divisao: " + div);
        Console.WriteLine("Resto: " + resto);
    }
}