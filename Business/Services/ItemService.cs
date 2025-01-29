using Models.Items;
using HomeControl.EFCore.Data;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Security.Cryptography.X509Certificates;

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
                Unidade  = unidadeMedida
            };

            _context.Itens.Add(item);

            _context.SaveChanges();
        }

        public ItemEstoque RemoveItem(int id)
        {
            var item = _context.Itens.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _context.Itens.Remove(item);
                _context.SaveChanges();
                return item;
            }
            else
            {
                return null;
            }
        }

        public List<ItemEstoque> BuscarItens()
        {
            return _context.Itens.ToList();
        }
    }
}

