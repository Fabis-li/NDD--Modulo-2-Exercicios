namespace exercicio;

     public class Program
     {
          public static void Main(string[] args)
          {
               Empregado empregado = new Empregado();
               empregado.id = 1;
               empregado.nome = "João";
               Console.WriteLine($"Id do funcionário: {empregado.id}");
               Console.WriteLine($"Nome do funcionário:{empregado.nome}");
               empregado.Trabalhar();
               empregado.IrEmbora();
               empregado.TirarFolga();
               Console.WriteLine("===========================");

               FuncionarioHorista funcionario = new FuncionarioHorista();
               funcionario.id = 2;
               funcionario.nome = "Marcelo";
               funcionario.cnpj = "12345";
               funcionario.taxa = 0.1;
               Console.WriteLine($"Id do funcionário: {funcionario.id}");
               Console.WriteLine($"Nome do funcionário:{funcionario.nome}");
               Console.WriteLine($"CNPJ do funcionario: {funcionario.cnpj}");
               Console.WriteLine($"A taxa é:{funcionario.taxa}");
               funcionario.CalcularTaxas();
               funcionario.EmitirNota();
               Console.WriteLine("============================");

               SalarioEmpregado salarioEmpregado = new SalarioEmpregado();
               salarioEmpregado.id = 1;
               salarioEmpregado.nome = "João";
               salarioEmpregado.codigoFuncionario = 1;
               salarioEmpregado.valorSalario = 1000;
               Console.WriteLine($"Id do funcionário: {salarioEmpregado.id}");
               Console.WriteLine($"Nome do funcionário:{salarioEmpregado.nome}");
               Console.WriteLine($"Código do funcionario: {salarioEmpregado.codigoFuncionario}");
               Console.WriteLine($"O salário do funcionario: {salarioEmpregado.valorSalario}");
               salarioEmpregado.CalcularFolhaDePagamento();
               Console.WriteLine("==============================");

               Secretaria secretaria = new Secretaria();
               secretaria.id = 3;
               secretaria.nome = "Mara";
               secretaria.qtdeAnosEmpresa = 10;
                Console.WriteLine($"Id da secretária: {secretaria.id}");
               Console.WriteLine($"Nome da secretária:{secretaria.nome}");
               Console.WriteLine($"Quantos anos tem de empresa: {secretaria.qtdeAnosEmpresa}");
               secretaria.AtenderCliente();
               secretaria.RealizarLigacoes();
               Console.WriteLine("============================");
               
               


               
          }
     }

