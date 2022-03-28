using Projeto_01.Domain.Contratos;
using Projeto_01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Repository.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository()
        {

        }
    }
}
