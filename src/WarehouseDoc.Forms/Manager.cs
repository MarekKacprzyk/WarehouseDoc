using System.Collections.ObjectModel;
using WarehouseDoc.Forms.ViewModels;

namespace WarehouseDoc.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Manager
    {

        public Manager()
        {
            var data = new List<AlphaViewModel>()
            {
                new AlphaViewModel { Id = 1, Header = "Doc1", Client = "Marek", NetPrice = 122, GrossPrice = 100, Amoud = 4 },
                new AlphaViewModel { Id = 2, Header = "Doc2", Client = "Karol", NetPrice = 122, GrossPrice = 100, Amoud = 3 },
                new AlphaViewModel { Id = 3, Header = "Doc3", Client = "Wojtek", NetPrice = 122, GrossPrice = 100, Amoud = 5 },
            };

            Source = new ObservableCollection<AlphaViewModel>(data);
        }

        public ObservableCollection<AlphaViewModel> Source { get;  }

        public AlphaViewModel SelectedItem { get; set; }
    }
}
