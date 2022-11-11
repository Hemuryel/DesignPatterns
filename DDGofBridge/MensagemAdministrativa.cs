using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Enviar()
        {
            this.Enviador.Enviar(this);
        }

        public string Formatar()
        {
            return $"Mensagem para o administrador {nome}";
        }
    }
}
