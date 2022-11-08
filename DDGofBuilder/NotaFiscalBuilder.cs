using System;
using System.Collections;
using System.Collections.Generic;

namespace DDGofBuilder
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
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        //Builder = esconder complexidade
        public NotaFiscal Builder()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }
    }
}