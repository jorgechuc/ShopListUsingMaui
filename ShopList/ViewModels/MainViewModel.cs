using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Models;
<<<<<<< HEAD
using ShopList.Persistence;
=======
>>>>>>> df6b10c3096253867d02b27571fb308bb5c96f16
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
<<<<<<< HEAD
                return;
            }
            ShopListItem item = new ShopListItem(ItemName); 
            await _database.SaveShopListItem(item);
=======
                Name = ItemName,
                IsBought = false
            };
>>>>>>> df6b10c3096253867d02b27571fb308bb5c96f16
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
