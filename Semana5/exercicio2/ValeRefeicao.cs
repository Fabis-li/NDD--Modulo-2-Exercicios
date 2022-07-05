namespace exercicio2
{
    public class ValeRefeicao : Cartao
    {
        public ValeRefeicao()
        {            
        }
         public override void VerificarValorTaxaCartao(double valorDaTaxa)
        {
           Console.WriteLine("O valor da taxa e saldo disponibilizado é " + valorDaTaxa * 0.08);

        }
    }
}