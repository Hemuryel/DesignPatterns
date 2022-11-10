using System;

namespace DDGofBuilder
{
    internal class Program
    {
        /* Builder
         * 
         * encapsular a lógica de construção de um objeto
         * diminuir complexidade
         */

        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            //interface fluente, method chaining
            criador
                .ParaEmpresa("Caelum Ensino e Inovação.")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemNota("Item 1", 100.0))
                .ComItem(new ItemNota("Item 2", 200.0))
                .NaDataAtual(new DateTime(2022, 11, 10))
                .ComObservacoes("Uma obs qualquer");

            //Builder não precisaria para ItemNota por ser muito simples
            ItemNotaBuilder nota4 = new ItemNotaBuilder();
            nota4
                .SetNome("Item 3")
                .SetValor(100);

            ItemNotaBuilder nota5 = new ItemNotaBuilder();
            nota5
                .SetNome("Item 5")
                .SetValor(100);

            criador
                .ComItem(nota4.Builder())
                .ComItem(nota5.Builder());

            //Outra forma sem Builder
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
