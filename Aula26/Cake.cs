namespace Aula26
{
    public class Cake
    {
        public string Sabor { get; set; }
        public string Recheio { get; set; }
        public string Cobertura { get; set; }
        public decimal Tamanho { get; set; }
        public decimal Valor { get; set; }
        public Cake(string sabor, string recheio, string cobertura, decimal tamanho, decimal valor)
        {
            Sabor = sabor;
            Recheio = recheio;
            Cobertura = cobertura;
            Tamanho = tamanho;
            Valor = valor;
        }
    }
}