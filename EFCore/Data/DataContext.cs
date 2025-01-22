using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.models;


namespace EFCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DbSet<ItemEstoque> Itens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HomeControl.db");
        }
    }
}
