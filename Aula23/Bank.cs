namespace Aula23
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Bank(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void RequestNewCard()
        {
            Console.WriteLine("Enviando Email...");
            Console.WriteLine("Solicite um novo cartao ligando para 8888-8888");
        }
    }
}