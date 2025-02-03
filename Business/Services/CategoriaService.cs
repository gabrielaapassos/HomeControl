using Models.Items;
using HomeControl.EFCore.Data;

namespace HomeControl.Business.Services
{
    public class CategoriaService
    {
        private readonly DataContext _context;


        public CategoriaService(DataContext context)
        {
            _context = context;
        }

        public void AdicionarCategoria(string nome, string descricao)
        {
            var categoria = new Categoria
            {
                Nome = nome,
                Descricao = descricao
            };

            _context.Categorias.Add(categoria);

            _context.SaveChanges();
        }

        public List<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categoria RemoveCategoria(int id) {
            var categoria = PegaCategoria(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
                return categoria;
            }
            else
            {
                return null;
            }
        }

        public Categoria PegaCategoria(int id)
        {
            return _context.Categorias.FirstOrDefault(i => i.Id == id);
        }
    }
}


