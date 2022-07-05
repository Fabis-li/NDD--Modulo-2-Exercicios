namespace exercicio
{
    public class Secretaria : Empregado
    {
        public int qtdeAnosEmpresa { get; set; }

        public Secretaria()
        {            
        }

        public Secretaria(int id, string nome, int qtdeAnosEmpresa) : base (id, nome)
        {
            this.qtdeAnosEmpresa = qtdeAnosEmpresa;
        }

        public void AtenderCliente()
        {
            Console.WriteLine("Atendendo Cliente");
        }

        public void RealizarLigacoes()
        {
            Console.WriteLine("Ligando....Alô");
        }
    }
}