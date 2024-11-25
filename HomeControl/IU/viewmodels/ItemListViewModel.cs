using System.Collections.ObjectModel;
using HomeControl.model;

namespace HomeControl.IU.viewmodels
{
    public class ItemListViewModel
    {
        public ObservableCollection<Item> Itens { get; set; }

        public ItemListViewModel()
        {
            // Carrega alguns itens de exemplo
            Itens = new ObservableCollection<Item>
            {
                new Item(1, "Leite", 2, "25/10/2024"),
                new Item(2, "Arroz", 5, "12/11/2024")
            };
        }
    }
}
