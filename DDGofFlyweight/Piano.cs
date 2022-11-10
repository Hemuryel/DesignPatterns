using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofFlyweight
{
    internal class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
