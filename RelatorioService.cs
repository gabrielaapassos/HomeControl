using System;

public class RelatorioService
{
    public class RelatorioService
    {
        public RelatorioConsumo GerarRelatorioConsumo(IEnumerable<ProdutoConsumido> consumos)
        {
            return new RelatorioConsumo
            {
                DataGeracao = DateTime.Now,
                ProdutosConsumidos = consumos.ToList()
            };
        }

        public RelatorioEstoqueBaixo GerarRelatorioEstoqueBaixo(IEnumerable<ItemEstoque> itens, int quantidadeMinima)
        {
            var itensBaixos = itens.Where(i => i.Quantidade < quantidadeMinima).ToList();
            return new RelatorioEstoqueBaixo
            {
                DataGeracao = DateTime.Now,
                ItensEmBaixa = itensBaixos
            };
        }
    }
}
