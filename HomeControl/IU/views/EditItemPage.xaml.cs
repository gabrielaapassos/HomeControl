using System.Windows.Input;
using HomeControl.model;
using Microsoft.Maui.Controls;

namespace HomeControl.IU.viewmodels
{
    public class EditItemViewModel
    {
        public Item Item { get; set; }
        public ICommand SalvarCommand { get; }

        public EditItemViewModel()
        {
            // Exemplo de instância do item. Em uma aplicação real, o item seria passado como parâmetro ou carregado.
            Item = new Item(1, "Item de Exemplo", 10, "01/01/2025");

            SalvarCommand = new Command(SalvarAlteracoes);
        }

        private void SalvarAlteracoes()
        {
            // Lógica para salvar as alterações feitas no item
            Application.Current.MainPage.DisplayAlert("Sucesso", "Alterações salvas com sucesso!", "OK");
        }
    }
}
