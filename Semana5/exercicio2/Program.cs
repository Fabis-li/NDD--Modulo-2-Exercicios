using System;

namespace exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cartao va = new ValeAlimentacao();
            va.bandeira = "Visa";
            va.saldo = 1000;
            va.valorTaxa = 0.02;
            

            Console.WriteLine($"O cartão de bandeira {va.bandeira}, com saldo inicial de R$ {va.saldo}, com taxa de {va.valorTaxa}");
            va.VerificarValorTaxaCartao(1000);

            Cartao vr = new ValeRefeicao();
            vr.bandeira = "Teste";
            vr.saldo = 300;
            vr.valorTaxa = 0.02;

             Console.WriteLine($"O cartão de bandeira {vr.bandeira}, com saldo inicial de R$ {vr.saldo}, com taxa de {vr.valorTaxa}");
             vr.VerificarValorTaxaCartao(1000);

             Cartao vt = new ValeTransporte();
             vt.bandeira = "master";
             vt.saldo = 200;
             vt.valorTaxa = 0.02;

             Console.WriteLine($"O cartão de bandeira {vt.bandeira}, com saldo inicial de R$ {vt.saldo}, com taxa de {vt.valorTaxa}");
             vt.VerificarValorTaxaCartao(1000);


            ValeAlimentacao valeAlimentacao = new ValeAlimentacao();
            Cartao cartaoVa = valeAlimentacao;
            cartaoVa.VerificarValorTaxaCartao(1000);

            ValeRefeicao valeRefeicao = new ValeRefeicao();
            Cartao cartaoVr = valeRefeicao;
            cartaoVr.VerificarValorTaxaCartao(1000);

            ValeTransporte valeTransporte = new ValeTransporte();
            Cartao cartaoVt = valeTransporte;
            cartaoVt.VerificarValorTaxaCartao(1000);


            ValeAlimentacao vaDownCasting = (ValeAlimentacao)cartaoVa;
            vaDownCasting.VerificarValorTaxaCartao(100);

            ValeRefeicao vrDownCasting = (ValeRefeicao)cartaoVr;
            vrDownCasting.VerificarValorTaxaCartao(100);

            ValeTransporte vtDownCasting = (ValeTransporte)cartaoVt;
            vtDownCasting.VerificarValorTaxaCartao(100);


            

        }
    }
}
