using System;
using System.Collections;
using System.Collections.Generic;

namespace DDGofObserver
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemNota> todosItens = new List<ItemNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscalBuilder AdicionarAcao(IAcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
            return this;
        }

        public NotaFiscalBuilder()
        {

        }

        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> lista)
        {
            this.todasAcoesASeremExecutadas = lista;
        }

        //Builder = esconder complexidade
        public NotaFiscal Builder()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            //new EnviadorEmail().EnviarEmail(nf);
            //new NotaFiscalDAO().SalvarBanco(nf);
            //new EnviadorSMS().EnviarSMS(nf);

            //Observer
            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executar(nf);
            }

            return nf;
        }
    }
}