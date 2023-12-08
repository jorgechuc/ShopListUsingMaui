using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Models;
using ShopList.Persistence;
using System.Collections.ObjectModel;

namespace ShopList.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _itemName;

        [ObservableProperty]
        public ObservableCollection<ShopListItem> _shopList;

        private ShopListItemDatabase _database;

        public MainViewModel()
        {
            _database = new ShopListItemDatabase();
            LoadShopListAsync();
            
        }

        [RelayCommand]
        private async Task Add()
        {
            if (string.IsNullOrEmpty(ItemName)) 
            {
                return;
            }
            ShopListItem item = new ShopListItem(ItemName); 
            await _database.SaveShopListItem(item);
            ShopList.Add(item);
        }

        private async void LoadShopListAsync()
        {
            ShopList = new ObservableCollection<ShopListItem>();
            var items = await _database.GetShopListItems();
            if (items is not null && items.Any<ShopListItem>())
            {
                foreach (var item in items)
                {
                    ShopList.Add(item);
                }
            }
        }
    }
}
