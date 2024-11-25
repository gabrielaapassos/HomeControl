using System.Collections.ObjectModel;
using HomeControl.model;

namespace HomeControl.IU.viewmodels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Item> Itens { get; set; }

        public MainPageViewModel()
        {
            // Dados de exemplo para itens
            Itens = new ObservableCollection<Item>
            {
                new Item(1, "Maçã", 10, "15/11/2024"),
                new Item(2, "Sabão", 3, "10/12/2024")
            };
        }
    }
}
