using System;

namespace DDGofProxy
{
    //Proxy
    //contém uma referência à classe RealSubject e pode acessar
    //os membros da classe RealSubject conforme necessário. 
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pasta;
        private Funcionario funcionario;
        public PastaCompartilhadaProxy(Funcionario funci)
        {
            funcionario = funci;
        }
        public void OperacaoDeLeituraGravacao()
        {
            if (funcionario.Perfil.ToUpper() == "CEO")
            {
                pasta = new PastaCompartilhada();
                Console.WriteLine("O proxy 'Pasta Compartilhada' invoca a pasta Real" +
                    " : 'método usado : OperacaoDeLeituraGravacao()\n");
                pasta.OperacaoDeLeituraGravacao();
            }
            else
            {
                Console.WriteLine("O proxy 'Pasta Compartilhada'  avisa : " +
                    "'Você não tem permissão para acessar esta pasta'\n");
            }
        }
    }
}
