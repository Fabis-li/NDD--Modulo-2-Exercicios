namespace exercicio2
{
    public class ValeTransporte : Cartao
    {
        public ValeTransporte()
        {            
        }
         public override void VerificarValorTaxaCartao(double valorDaTaxa)
        {
           Console.WriteLine("O valor da taxa e saldo disponibilizado é " + valorDaTaxa * 0.06);

        }
    }
}