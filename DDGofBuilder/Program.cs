using System;

namespace DDGofBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            //interface fluente, method chaining
            criador
                .ParaEmpresa("Caelum Ensino e Inovação.")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemNota("Item 1", 100.0))
                .ComItem(new ItemNota("Item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer");

            //criador.ParaEmpresa("Caelum Ensino e Inovação.");
            //criador.ComCnpj("23.456.789/0001-12");
            //criador.ComItem(new ItemNota("Item 1", 100.0));
            //criador.ComItem(new ItemNota("Item 2", 200.0));
            //criador.NaDataAtual();
            //criador.ComObservacoes("Uma obs qualquer");

            NotaFiscal nf = criador.Builder();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}
