﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Core.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            mensagem = mensagem;
        }

        public string mensagem { get; }
    }
}
