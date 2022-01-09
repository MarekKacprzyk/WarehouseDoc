using System.Collections.ObjectModel;
using WarehouseDoc.Forms.ViewModels;

namespace WarehouseDoc.Forms
{
    using System.Collections.Generic;

    public class Manager : BasePropertyChanged
    {
        private DocumnetViewModel _selectedItem;

        public Manager()
        {
            var data = new List<DocumnetViewModel>
            {
                new DocumnetViewModel { Id = 1, Header = "Doc1", Client = "Marek", NetPrice = 122, GrossPrice = 100, Amoud = 4 },
                new DocumnetViewModel { Id = 2, Header = "Doc2", Client = "Karol", NetPrice = 122, GrossPrice = 100, Amoud = 3 },
                new DocumnetViewModel { Id = 3, Header = "Doc3", Client = "Wojtek", NetPrice = 122, GrossPrice = 100, Amoud = 5 },
            };

            Source = new ObservableCollection<DocumnetViewModel>(data);

        }

        public ObservableCollection<DocumnetViewModel> Source { get;  }

        public DocumnetViewModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value; 
                OnPropertyChanged(nameof(Id));
                OnPropertyChanged(nameof(Header));
                OnPropertyChanged(nameof(Client));
                OnPropertyChanged(nameof(GrossPrice));
                OnPropertyChanged(nameof(NetPrice));
                OnPropertyChanged(nameof(Amoud));
            }
        }

        public int Id
        {
            get => SelectedItem.Id;
            set
            {
                SelectedItem.Id = value; 
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Header
        {
            get => SelectedItem.Header;
            set
            {
                SelectedItem.Header= value;
                OnPropertyChanged(nameof(Header));
            }
        }

        public string Client
        {
            get => SelectedItem.Client;
            set
            {
                SelectedItem.Client= value;
                OnPropertyChanged(nameof(Client));
            }
        }

        public decimal GrossPrice
        {
            get => SelectedItem.GrossPrice;
            set
            {
                SelectedItem.GrossPrice = value;
                OnPropertyChanged(nameof(GrossPrice));
            }
        }

        public decimal NetPrice
        {
            get => SelectedItem.NetPrice;
            set
            {
                SelectedItem.NetPrice= value;
                OnPropertyChanged(nameof(NetPrice));
            }
        }

        public int Amoud
        {
            get => SelectedItem.Amoud;
            set
            {
                SelectedItem.Amoud= value;
                OnPropertyChanged(nameof(Amoud));
            }
        }
    }
}
