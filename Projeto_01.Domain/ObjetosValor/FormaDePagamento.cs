using System;
using System.Collections.Generic;
using System.Text;
using Projeto_01.Domain.Utils.Enums;

namespace Projeto_01.Domain.ObjetosValor
{
    public class FormaDePagamento
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
                    
        }
        public bool EhCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaCredito; }

        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }

        }
    }
}
