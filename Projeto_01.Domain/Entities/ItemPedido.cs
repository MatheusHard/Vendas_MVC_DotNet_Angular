using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Domain.Entities
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public string ProdutoId { get; set;}
        public int Qtd { get; set; }
    }
}
