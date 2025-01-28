using Microsoft.EntityFrameworkCore;
using Models.Items;

namespace HomeControl.EFCore.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ItemEstoque> Itens { get; set; }

        // Construtor sem parâmetros para situações específicas
        public DataContext() { }

        // Construtor recomendado para passar opções
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Evitar configurar se já configurado
            {
                // Caminho relativo ao diretório do projeto
                var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HomeControl.db");
                optionsBuilder.UseSqlite($"Data Source={path}");
            }
        }
    }
}
