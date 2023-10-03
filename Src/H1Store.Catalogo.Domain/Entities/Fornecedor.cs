using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor(int código, string razãoSocial, string cNPJ, bool ativo, DateTime dataCadastro, string emailContato)
        {
            Código = código;
            RazãoSocial = razãoSocial;
            CNPJ = cNPJ;
            Ativo = ativo;
            DataCadastro = dataCadastro;
            EmailContato = emailContato;
        }

        public int Código { get; set; }
        public string RazãoSocial { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string EmailContato { get; set; }
    }
}
