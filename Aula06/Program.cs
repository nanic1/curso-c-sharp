namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite numero 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        if (number1 % 2 == 0)
        {
            Console.WriteLine("O número " + number1 + " é par");
        }
        else
        {
            Console.WriteLine("O número " + number1 + " é impar");
        }
    }
}