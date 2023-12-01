using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Models;
using System.Collections.ObjectModel;

namespace ShopList.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _itemName;

        public ObservableCollection<ShopListItem> ShopList { get; set; }

        public MainViewModel()
        {
            ShopList = new ObservableCollection<ShopListItem>();
        }

        [RelayCommand]
        private void Add()
        {
            ShopListItem item = new ShopListItem 
            {
                Name = ItemName,
                IsBought = false
            };
            ShopList.Add(item);
        }
    }
}
