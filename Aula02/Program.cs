using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Aula02;

public class Program
{
    public static void Main()
    {
        string myName = "Antonio"; // Variavel palavras
        int number = 20; // Variavel numeros inteiros
        double numberDouble = 10.5; // Variavel numeros reais
        char character = 'a'; // Variavel caracteres
        bool boolean = true; // Variavel Booleana

        Console.WriteLine(myName);
        Console.WriteLine(number);
        Console.WriteLine(numberDouble);
        Console.WriteLine(character);
        Console.WriteLine(boolean);
    }
}