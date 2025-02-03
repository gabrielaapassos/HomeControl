using Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Items
{
    public class ProdutoConsumido
    {
        public int Id { get; set; }
        public ItemEstoque Item { get; set; }
        public DateTime DataConsumo { get; set; }
        public int QuantidadeConsumida { get; set; }
    }
}
