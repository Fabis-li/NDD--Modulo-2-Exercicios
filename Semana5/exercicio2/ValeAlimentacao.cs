namespace exercicio2
{
    public class ValeAlimentacao : Cartao
    {
        public ValeAlimentacao()
        {            
        }
        public override void VerificarValorTaxaCartao(double valorDaTaxa)
        {
           Console.WriteLine("O valor da taxa e saldo disponibilizado é " + valorDaTaxa * 0.10);

        }
    }   

    
}