using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Done = false
            };
            ShopList.Add(item);
        }
    }
}
