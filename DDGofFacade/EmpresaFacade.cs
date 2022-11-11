using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofFacade
{
    public class EmpresaFacade
    {
        public Cliente BuscarCliente(string cpf)
        {
            return new ClienteDAO().BuscarPorCpf(cpf);
        }

        public Fatura CriarFatura(Cliente cliente, double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GerarCobranca(Fatura fatura, Cliente cliente)
        {

            Cobranca cobranca = new Cobranca();
            cobranca.Emitir(fatura, cliente);
            return cobranca;
        }

        public ContatoCliente FazerContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Disparar();
            return contato;
        }
    }
}
