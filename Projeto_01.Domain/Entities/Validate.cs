using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace Projeto_01.Domain.Entities
{
    public abstract class EntityValidate
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
        protected void AdicionarMensagem(string m)
        {
            mensagemValidacao.Add(m);
        }

        protected void LimparMensagem()
        {
            mensagemValidacao.Clear();
        }

    }
}





































