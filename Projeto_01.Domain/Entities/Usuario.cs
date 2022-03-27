using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Name { get; set; }
        
        //Nehumou varios pedidos
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
