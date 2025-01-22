using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Models.models;
using EFCore.Data.DBOperations;
//using Database;

namespace HomeControl
{
    public partial class MainPage : ContentPage
    {
        private readonly DataContext _context;

        public MainPage(DataContext context)
        {
            InitializeComponent();
            _context = context;
        }
        private async void OnSalvarCliked(object sender, EventArgs e)
        {
            Item item = new();
            item.Id = (int)ItemId.Value;
            item.Validade = Validade.Text;
            item.Nome = Nome.Text;
            item.Quantidade = (int)Quantidade.Value;
            //item.Categoria = DataEntry.Text;



            ResultadoLabel.Text = item.ToString();
            try
            {
                Insert.TbItem(item.Nome, item.Quantidade, item.Validade);
                ResultadoLabel.Text = "deu bom";
                ResultadoDbLabel.Text = _context.Itens.FirstOrDefault().ToString();
            }
            catch (Exception)
            {
                ResultadoDbLabel.Text = "deu ruim";
                throw;
            }
        }

        private void UpdateCounter(object sender, ValueChangedEventArgs e)
        {
            var Controler = sender as Stepper;
            if (Controler != null)
            {
                var LabelName = Controler.StyleId.ToString();
                var Counter = this.FindByName<Label>(LabelName);
                if (Counter != null)
                {
                    Counter.Text = $"valor: {e.NewValue}";
                }
            }
        }
    }
}


