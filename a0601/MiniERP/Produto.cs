using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
