using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Interfaces
{
    public interface FornecedorRepository : IRepository<Fornecedor>
    {
        Fornecedor GetById(int id);
        IEnumerable<Fornecedor> GetAll();
        void Add(Fornecedor fornecedor_entity);
        void Update(Fornecedor fornecedor_entity);
        void Remove(int id);

    }
}
