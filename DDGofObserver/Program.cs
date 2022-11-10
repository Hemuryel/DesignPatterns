using System;
using System.Collections;
using System.Collections.Generic;

namespace DDGofObserver
{
    internal class Program
    {
        /* Observer
         * 
         * define uma dependência um-para-muitos entre os objetos 
         * de modo que quando um objeto muda de estado, 
         * todos os seus dependentes são notificados 
         * e atualizados automaticamente
         */

        static void Main(string[] args)
        {
            //Outra forma
            //IList<IAcaoAposGerarNota> lista = new List<IAcaoAposGerarNota>();
            //lista.Add(new EnviadorEmail());
            //lista.Add(new NotaFiscalDAO());
            //lista.Add(new EnviadorSMS());
            //lista.Add(new Multiplicador(1));
            //lista.Add(new Multiplicador(2));

            //NotaFiscalBuilder criador = new NotaFiscalBuilder(lista);
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            //interface fluente, method chaining
            criador
                .ParaEmpresa("Caelum Ensino e Inovação.")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemNota("Item 1", 100.0))
                .ComItem(new ItemNota("Item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer");

            criador
                .AdicionarAcao(new EnviadorEmail())
                .AdicionarAcao(new NotaFiscalDAO())
                .AdicionarAcao(new EnviadorSMS())
                .AdicionarAcao(new Multiplicador(1))
                .AdicionarAcao(new Multiplicador(2));

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
