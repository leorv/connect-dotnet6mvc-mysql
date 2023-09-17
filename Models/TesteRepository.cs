using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[] {
            new Produto{ Id=1, Nome="Caneta", Categoria="Escritório", Preco=3.4M}
        };

        public IEnumerable<Produto> Produtos {get => produtos;}
    }
}