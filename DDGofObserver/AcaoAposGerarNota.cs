﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofObserver
{
    public interface AcaoAposGerarNota
    {
        void Executar(NotaFiscal nf);
    }
}
