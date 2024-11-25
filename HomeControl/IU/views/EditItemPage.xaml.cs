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
            // Exemplo de inst�ncia do item. Em uma aplica��o real, o item seria passado como par�metro ou carregado.
            Item = new Item(1, "Item de Exemplo", 10, "01/01/2025");

            SalvarCommand = new Command(SalvarAlteracoes);
        }

        private void SalvarAlteracoes()
        {
            // L�gica para salvar as altera��es feitas no item
            Application.Current.MainPage.DisplayAlert("Sucesso", "Altera��es salvas com sucesso!", "OK");
        }
    }
}
