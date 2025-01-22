using HomeControl.EFCore.Data;
using HomeControl.Model.Items;

namespace HomeControl.Business.Services
{
    public class ItemService
    {
        private readonly DataContext _context;

        public ItemService(DataContext context)
        {
            _context = context;
        }

        public void AdicionarItem(string nome, string categoria, int quantidade, DateTime? validade)
        {
            var item = new ItemEstoque
            {
                Nome = nome,
                Categoria = categoria,
                Quantidade = quantidade,
                DataAdicao = DateTime.Now,
                DataValidade = validade
            };

            _context.ItensEstoque.Add(item);
            _context.SaveChanges();
        }
    }
}
