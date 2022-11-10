using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBuilder
{
    internal class ItemNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemNotaBuilder SetNome(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public ItemNotaBuilder SetValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemNota Builder()
        {
            return new ItemNota(Nome, Valor);
        }
    }
}
