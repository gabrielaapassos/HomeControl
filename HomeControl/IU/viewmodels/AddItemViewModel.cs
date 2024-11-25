using System.Windows.Input;
using HomeControl.model;
using Microsoft.Maui.Controls;

namespace HomeControl.IU.viewmodels
{
    public class AddItemViewModel
    {
        public Item NovoItem { get; set; }

        public ICommand AdicionarItemCommand { get; }

        public AddItemViewModel()
        {
            NovoItem = new Item(0, "", 0, "");
            AdicionarItemCommand = new Command(AdicionarItem);
        }

        private void AdicionarItem()
        {
            // Lógica para adicionar o item ao inventário (pode ser substituído por lógica de persistência)
            Application.Current.MainPage.DisplayAlert("Sucesso", "Item adicionado com sucesso!", "OK");
        }
    }
}
