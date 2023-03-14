﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeContaCorrente
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem,excecaoInterna)
        {

        }
    }
}
