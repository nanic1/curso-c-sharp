using System.ComponentModel;

namespace Aula23;

public class Program
{
    public static void Main()
    {
        var banco = new Bank(
            1,
            "Banco new"
        );
        Console.WriteLine($"Id: {banco.Id}");
        Console.WriteLine($"Nome: {banco.Name}");
        banco.RequestNewCard();
    }
}