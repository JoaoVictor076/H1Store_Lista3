using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Interfaces
{
    public interface CategoriaRepository : IRepository<Categoria>
    {
        Categoria GetById(int id);
        IEnumerable<Categoria> GetAll();
        void Add(Categoria categoria_entity);
        void Update(Categoria categoria_entity);
        void Remove(int id);
    }
}
