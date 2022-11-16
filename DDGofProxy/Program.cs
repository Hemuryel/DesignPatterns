using System;

namespace DDGofProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Exemplo de implementação do padrão Proxy ###\n");

            //acesso Programador
            Console.WriteLine("\nFuncionário com perfil 'Programador' acessando " +
                "a Pasta Compartilhada Proxy");

            Funcionario funci1 = new Funcionario("Macoratti", "123456", "Programador");
            PastaCompartilhadaProxy pastaDDGofProxy = new PastaCompartilhadaProxy(funci1);
            pastaDDGofProxy.OperacaoDeLeituraGravacao();

            //acesso Usuario
            Console.WriteLine("\nFuncionário com perfil 'Usuario' acessando a Pasta " +
                "Compartilhada Proxy");

            Funcionario funci2 = new Funcionario("Amanda", "123456", "Usuario");
            PastaCompartilhadaProxy pastaProxy2 = new PastaCompartilhadaProxy(funci2);
            pastaProxy2.OperacaoDeLeituraGravacao();

            //acesso Ceo
            Console.WriteLine("\nFuncionário com perfil 'Ceo' acessando a " +
                "Pasta Compartilhada Proxy");

            Funcionario funci3 = new Funcionario("Bill Gates", "876543", "Ceo");
            PastaCompartilhadaProxy pastaProxy3 = new PastaCompartilhadaProxy(funci3);
            pastaProxy3.OperacaoDeLeituraGravacao();

            Console.Read();
        }
    }
}
