using System.Xml;

namespace HomeControl
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSalvarCliked(object sender, EventArgs e)
        {
            model.Item item = new model.Item();
            item.Categoria = DataEntry.Text;
            ResultadoLabel.Text = item.Categoria.ToString();

        }
    }
}


