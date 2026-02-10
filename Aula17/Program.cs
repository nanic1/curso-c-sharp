namespace Aula17;

public class Program
{
    public static void Main()
    {
        List<string> frutas = new List<string>()
        {
            "Maca",
            "Banana",
            "Abacaxi",
            "Pera"
        };

        frutas.Add("Limao");
        frutas.Add("Laranja");

        frutas.Remove("Limao");

        foreach(string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine($"Quantidade de frutas: {frutas.Count}");

        frutas[4] = "Maracuja";

        foreach(string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        frutas.Clear();

        foreach(string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}