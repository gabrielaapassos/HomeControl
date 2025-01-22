using Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Reports
{
    public class RelatorioEstoqueBaixo
    {
        public int Id { get; set; }
        public DateTime DataGeracao { get; set; }
        public ICollection<ItemEstoque> ItensEmBaixa { get; set; }
    }
}
