using Microsoft.EntityFrameworkCore;
using Models.Items;

namespace HomeControl.EFCore.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ItemEstoque> Itens { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        // Construtor sem parâmetros para situações específicas
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Caminho relativo ao diretório do projeto
                var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HomeControl.db");
                optionsBuilder.UseSqlite($"Data Source={path}");
                //string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

                //// Caminho correto do banco de dados dentro de EFCore
                //string dbPath = Path.Combine(projectRoot, "EFCore", "HomeControl.db");

                //optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }
    }
}
