using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Models.models;

namespace HomeControl
{
    public partial class App : Application
    {
        private readonly DataContext _context;

        public App(DataContext context)
        {
            InitializeComponent();

            MainPage = new AppShell();
            _context = context;
        }

        protected override void OnStart()
        {
            _context.Database.Migrate();
            SeedDatabase();
        }

        private void SeedDatabase()
        {
            if (_context.Itens.Any())
                return;
            var item = new Item(1, "123", 3, "123")
            {
                Id = 1,
                Nome = "123",
                Quantidade = 3,
                Validade = "123"
            };
            _context.Itens.Add(item);
            _context.SaveChanges();
        }
    }
}
