namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1- Criando arquivo
        File.WriteAllText("teste.txt", "Hello World");
        Console.WriteLine("Arquivo criado com sucesso!");

        // 2- Criando arquivo em local especifico

        string caminho = @"C:\Users\pedro\Downloads\teste\file2.txt";

        File.WriteAllText(caminho, "Oie");
    }
}