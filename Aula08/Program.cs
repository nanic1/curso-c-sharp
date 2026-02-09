namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("X = ");
        
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        string resultado;

        // Operador de Igualdade (==)
        if(x == y)
        {
            resultado = "X é igual a Y";
        }
        else
        {
            resultado = "X é diferente de Y";
        }
        Console.WriteLine("Resultado (==): " + resultado);

        if (x != y)
        {
            resultado = "X é diferente de Y";
        }
        else
        {
            resultado = "X é igual a Y";
        }
        Console.WriteLine("Resultado (!=): " + resultado);

        if (x > y)
        {
            resultado = "X é maior que Y";
        }
        else
        {
            resultado = "X é menor que Y";
        }
        Console.WriteLine("Resultado (>): " + resultado);

        if(x < y)
        {
            resultado = "X é menor que Y";
        }
        else
        {
            resultado = "X é maior que Y";        
        }
        Console.WriteLine("Resultado (<): " + resultado);
    }
}