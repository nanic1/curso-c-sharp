namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------Atribuicao--------");

        int x = 10;
        Console.WriteLine("Valor inicial da variavel: " + x);

        // Atribuicao Simples
        x = 20;
        Console.WriteLine("Atribuicao Simples: " + x);

        // Incremento (+1)
        x++;
        Console.WriteLine("Incrementacao: "+ x);

        // Atribuicao Composta (+=)
        x += 10;
        Console.WriteLine("Atribuicao Composta: " + x);
    }
}