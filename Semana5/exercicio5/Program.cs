

namespace exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario objetofuncionario = new Funcionario("1", "Mario");
            
            try
            {
                ValidacaoFuncionario(objetofuncionario);
                MonstrarNomeFuncionario(objetofuncionario);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static void MonstrarNomeFuncionario(Funcionario objetofuncionario)
        {
            if(objetofuncionario == null)
            {
                throw new NullReferenceExeception("\nO objeto Funcionário é nulo. Informe os valores.\n");
            }
            Console.WriteLine(
                $"\n O nome do funcionário é {objetofuncionario.id}" + 
                $"\n O código do funcionário é {objetofuncionario.nome}"
            );
        }
        public static void ValidacaoFuncionario(Funcionario objetofuncionario)
        {
            Regex regexLetras = new Regex("^[a-zA-Z]+$");
            Regex regexNumeros = new Regex("^[0-9]+$");

            if(!regexLetras.IsMatch(objetofuncionario.nome))
            {
                throw new NomeFuncionarioInvalidoException(objetofuncionario.nome);
            }
            if(!regexNumeros.IsMatch(objetofuncionario.id))
            {  
               throw new  IdFuncionarioInvalidoException(objetofuncionario.id);
            }
        }
    }
}
