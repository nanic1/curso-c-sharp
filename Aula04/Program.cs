namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----------Login-----------");

        // Solicita nome do usuario

        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nome: " + name);
        Console.WriteLine("Idade: " + age);
    }
}