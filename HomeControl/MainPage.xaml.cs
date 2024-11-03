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
            ResultadoLabel.Text = item.ToString();

        }

        //private void UpdateCounter(object sender, ValueChangedEventArgs e)
        //{
        //    var teste = IdCounter.Text;
        //     IdCounter.Text = $"Valor {e.NewValue.ToString()}";
        //    //var Controler = sender as Stepper;
        //    //var Counter =  // this.FindByName<Label>($"{Controler.AutomationId}Counter");
        //    //Counter.Text = $"valor: {e.NewValue}";
        //}
    }
}


