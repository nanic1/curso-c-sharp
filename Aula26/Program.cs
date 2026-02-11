namespace Aula26;

public class Program
{
    public static void Main()
    {
        Cake boloChocolate = new Cake(
            "Chocolate",
            "Chocolate",
            "Morango",
            20m,
            50m
        );
        
        Console.WriteLine($"Sabor: {boloChocolate.Sabor}");
        Console.WriteLine($"Recheio: {boloChocolate.Recheio}");
        Console.WriteLine($"Cobertura: {boloChocolate.Cobertura}");
        Console.WriteLine($"Tamanho: {boloChocolate.Tamanho}cm");
        Console.WriteLine($"Valor: R${boloChocolate.Valor}");
    }
}