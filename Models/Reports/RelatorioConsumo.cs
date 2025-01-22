using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Reports
{
    public class RelatorioConsumo
    {
        public int Id { get; set; }
        public DateTime DataGeracao { get; set; }
        public ICollection<ProdutoConsumido> ProdutosConsumidos { get; set; }
    }
}
