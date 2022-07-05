namespace exercicio2
{
    public class Cartao
    {
        public string bandeira { get; set; }
        public double saldo { get; set; }
        public double valorTaxa { get; set; }

        public Cartao()
        {            
        }

        public Cartao(string bandeira, double saldo, double valorTaxa)
        {
            this.bandeira = bandeira;
            this.saldo = saldo;
            this.valorTaxa = valorTaxa;
        } 
        public virtual void VerificarValorTaxaCartao(double valorDaTaxa)
        {
           Console.WriteLine("O valor da taxa e saldo disponibilizado é " + valorDaTaxa * 0.02);
        }
    }
}