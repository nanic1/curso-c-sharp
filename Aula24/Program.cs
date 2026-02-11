namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person pessoa = new Person();

        Console.WriteLine("Digite uma idade: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        var ifLegalPerson = pessoa.IfLegalPerson(age);

        if (ifLegalPerson == true)
        {
            Console.WriteLine("Maior de idade.");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }
    }
}