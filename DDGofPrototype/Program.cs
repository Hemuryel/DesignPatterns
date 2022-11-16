using DDGofPrototype.ConcretePrototype;
using static System.Console;

namespace DDGofPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado = new Soldado();
            soldado.Nome = "Soldado1";
            soldado.Arma = "Fuzil HK G36";
            soldado.Acessorio = new Acessorio { Nome = "Visor Noturno" };

            //clone1 do objeto original
            Soldado soldado_clone1 = (Soldado)soldado.Clone();
            soldado_clone1.Nome = "Soldado clone1";
            soldado_clone1.Arma = "Fuzil Kalashinikov";
            soldado_clone1.Acessorio.Nome = "Colete Especial";

            //clone2 do objeto original
            Soldado soldado_clone2 = (Soldado)soldado.Clone();
            soldado_clone2.Nome = "Soldado clone2";
            soldado_clone2.Arma = "Fuzil AK105";
            soldado_clone2.Acessorio.Nome = "Gás mostarda";

            //exibe valores do objeto original
            WriteLine(">> Objeto Original");
            WriteLine($"{soldado.Nome} - {soldado.Arma}");
            WriteLine($"{soldado.Acessorio.Nome}\n");

            //clone1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldado_clone1.Nome} - {soldado_clone1.Arma}");
            WriteLine($"{soldado_clone1.Acessorio.Nome}\n");

            //clone2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma}");
            WriteLine($"{soldado_clone2.Acessorio.Nome}\n");

            ReadLine();

        }
    }
}
