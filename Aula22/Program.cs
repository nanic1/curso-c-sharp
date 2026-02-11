namespace Aula22;

using System.Globalization;
using Aula22;
public class Program
{
    public static void Main()
    {
        // Instanciando um bolo usando os atributos da classe Cake.cs
        Cake boloMorango = new Cake(
            400,
            "Bolo de Morango Recehado",
            "Intolerantes a lactose nao podem comer",
            "Morango",
            20m,
            true
        );

        Console.WriteLine($"Id: {boloMorango.Id}");
        Console.WriteLine($"Nome: {boloMorango.Nome}");
        Console.WriteLine($"OBS: {boloMorango.Obs}");
        Console.WriteLine($"Valor: {boloMorango.Preco}");
        Console.WriteLine($"É recheado? {boloMorango.isRecheado}");

        Cake boloChocolate = new Cake(
            401,
            "Bolo de Chocolate",
            "Nao contem gluten / Nao contem lactose",
            "Chocolate",
            25m,
            false
        );
        
        Console.WriteLine("");
        Console.WriteLine($"Id: {boloChocolate.Id}");
        Console.WriteLine($"Nome: {boloChocolate.Nome}");
        Console.WriteLine($"OBS: {boloChocolate.Obs}");
        Console.WriteLine($"Valor: {boloChocolate.Preco}");
        Console.WriteLine($"É recheado? {boloChocolate.isRecheado}");
    }
}