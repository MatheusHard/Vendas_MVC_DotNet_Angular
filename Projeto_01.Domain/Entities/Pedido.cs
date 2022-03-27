using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }


    }
}
