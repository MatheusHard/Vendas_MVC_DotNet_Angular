using Projeto_01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Domain.Contratos
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        ///Não precisa colocar osmetodos do BAse Repository, ja que esta como Herança dela
    }
}
