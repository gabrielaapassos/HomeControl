using HomeControl.EFCore.Data;
using HomeControl.Model.Items;

public class ItemService
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
        private readonly List<ItemEstoque> _itens;

        public ItemService()
        {
            _itens = new List<ItemEstoque>();
        }

        public void AdicionarItem(ItemEstoque item)
        {
            try
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item), "O item não pode ser nulo.");

                if (string.IsNullOrWhiteSpace(item.Nome))
                    throw new ArgumentException("O nome do item é obrigatório.");

                _itens.Add(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar item: {ex.Message}");
            }
        }

        public void AtualizarQuantidade(int itemId, int quantidade)
        {
            try
            {
                var item = _itens.FirstOrDefault(i => i.Id == itemId);

                if (item == null)
                    throw new KeyNotFoundException("Item não encontrado no estoque.");

                if (quantidade < 0)
                    throw new ArgumentException("A quantidade não pode ser negativa.");

                item.Quantidade = quantidade;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar quantidade: {ex.Message}");
            }
        }

        public void RemoverItem(int itemId)
        {
            try
            {
                var item = _itens.FirstOrDefault(i => i.Id == itemId);

                if (item == null)
                    throw new KeyNotFoundException("Item não encontrado no estoque.");

                _itens.Remove(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover item: {ex.Message}");
            }
        }

        public IEnumerable<ItemEstoque> ObterItensPorCategoria(string categoria)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(categoria))
                    throw new ArgumentException("A categoria não pode ser vazia.");

                return _itens.Where(i => i.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter itens por categoria: {ex.Message}");
                return Enumerable.Empty<ItemEstoque>();
            }
        }
    }
}
