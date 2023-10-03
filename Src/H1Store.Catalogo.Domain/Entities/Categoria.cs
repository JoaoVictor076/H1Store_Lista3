using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
    public class Categoria
    {
        public Categoria(int código, string descrição)
        {
            Código = código;
            Descrição = descrição;
        }

        public int Código { get; set; }
        public string Descrição { get; set; }
    }
}
