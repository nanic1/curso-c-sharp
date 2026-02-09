namespace Aula09;

public class Program
{
    public static void Main()
    {
        bool isLogged = true;
        bool hasAdminAcces = false;

        Console.WriteLine("Informacoes do usuario:");
        Console.WriteLine($"Usuario logado: {isLogged}");
        Console.WriteLine($"Acesso ao painel de administrador: {hasAdminAcces}");

        // && - E...
        if (isLogged && hasAdminAcces)
        {
            Console.WriteLine("Acesso ao painel de adminstrador concedido!");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de adminstrador negado.");
        }

        // || - Ou...
        if (isLogged || hasAdminAcces)
        {
            Console.WriteLine("Acesso ao painel de adminstrador concedido!");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de adminstrador negado.");
        }

        // ! - Nao...
        if (!isLogged)
        {
            Console.WriteLine("Acesso ao painel de adminstrador negado.");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de adminstrador concedido!");
        }
    }
}