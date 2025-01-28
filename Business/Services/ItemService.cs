using Models.Items;
using HomeControl.EFCore.Data;

namespace HomeControl.Business.Services
{
    public class ItemService
    {
        private readonly DataContext _context;


        public ItemService(DataContext context)
        {
            _context = context;
        }

        public void AdicionarItem(string nome, string categoria, int quantidade, DateTime? validade, string unidadeMedida)
        {
            var item = new ItemEstoque
            {
                Nome = nome,
                Categoria = categoria,
                Quantidade = quantidade,
                DataAdicao = DateTime.Now,
                Validade = validade,
                UnidadeMedida = unidadeMedida
            };

            _context.Itens.Add(item);
            _context.SaveChanges();
        }
    }
}
