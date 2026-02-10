namespace Aula16;

public class Program
{
    public static void Main()
    {
        string[] frutas = {"Maca", "Banana", "Caju"};

        Console.WriteLine(frutas[2]);

        foreach(string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

        frutas[1] = "Abacaxi";

        Console.WriteLine(frutas[1]);
    }
}