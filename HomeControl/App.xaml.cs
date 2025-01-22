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
        }

        private void SeedDatabase(string nome, int quantidade, string validade)
        {
            if (_context.Itens.Any())
                return;
            var item = new Item()
            {
                Nome = nome,
                Quantidade = quantidade,
                Validade = "123"
            };
            _context.Itens.Add(item);
            _context.SaveChanges();
        }
    }
}
