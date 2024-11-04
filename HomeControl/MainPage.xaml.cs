using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace HomeControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSalvarCliked(object sender, EventArgs e)
        {
            model.Item item = new((int)Id.Value, Nome.Text, (int)Quantidade.Value, Validade.Text);
            item.Id = (int)Id.Value;
            item.Validade = Validade.Text;
            item.Nome = Nome.Text;
            item.Quantidade = (int)Quantidade.Value;
            //item.Categoria = DataEntry.Text;

            var database = new Database;
            database.Create(item);


            ResultadoLabel.Text = item.ToString();

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


