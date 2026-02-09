namespace Aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------Dias da semana------");
        Console.WriteLine("Digite um número de 1 a 7: ");
        int week = Convert.ToInt32(Console.ReadLine());

        switch (week)
        {
            case 1:
                Console.WriteLine("O dia da semana é Segunda-Feira!");
                break;

            case 2:
                Console.WriteLine("O dia da semana é Terca-Feira!");
                break;

            case 3:
                Console.WriteLine("O dia da semana é Quarta-Feira!");
                break;

            case 4:
                Console.WriteLine("O dia da semana é Quinta-Feira!");
                break;

            case 5:
                Console.WriteLine("O dia da semana é Sexta-Feira!");
                break;

            case 6:
                Console.WriteLine("O dia da semana é Sábado!");
                break;

            case 7:
                Console.WriteLine("O dia da semana é Domingo!");
                break;

            default:
                Console.WriteLine("Dia da semana inexistente.");
                break;
        }
    }
}