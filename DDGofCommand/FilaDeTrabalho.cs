using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCommand
{
    public class FilaDeTrabalho
    {
        private IList<ICommand> Comandos = new List<ICommand>();

        public void Adicionar(ICommand comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processar()
        {
            foreach(var comando in this.Comandos)
            {
                comando.Executar();
            }
        }
    }
}
