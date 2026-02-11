namespace Aula22
{
    public class Cake
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Obs { get; set; }
        public string Sabor { get; set; }
        public decimal Preco { get; set; }
        public bool isRecheado { get; set; }

        public Cake(int id, string nome, string obs, string sabor, decimal preco, bool isrecheado)
        {
            Id = id;
            Nome = nome;
            Obs = obs;
            Sabor = sabor;
            Preco = preco;
            isRecheado = isrecheado;
        }
    }
}