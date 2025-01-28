using HomeControl.EFCore.Data;
using Models.Items;

namespace EFCore.Data.DBOperations
{
    public class Insert
    {
        private readonly DataContext _context;

        public Insert(DataContext context)
        {
            _context = context;
        }

        public void TbItem(string nome, int quantidade, DateTime? validade = null)
        {
            var item = new ItemEstoque
            {
                Nome = nome,
                Quantidade = quantidade,
                Validade = validade
            };

            _context.Itens.Add(item);
            _context.SaveChanges();
        }
    }
}
