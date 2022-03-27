using Projeto_01.Domain.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_01.Domain.Entities
{
    public class Pedido : EntityValidate
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento{ get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
                LimparMensagem();

            if (!ItensPedido.Any())
            {
                AdicionarMensagem("1 Item é Obrigatorio");
                
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagem("CEP não pode ser vazio!!!");

            }
        }
    }
}
