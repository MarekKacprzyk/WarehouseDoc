namespace WarehouseDoc.Forms.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class AlphaViewModel : BasePropertyChanged
    {
        private int _id;
        private string _header;
        private string _client;
        private decimal _grossPrice;
        private decimal _netPrice;
        private int _amoud;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Header
        {
            get => _header;
            set
            {
                _header = value;
                OnPropertyChanged(nameof(Header));
            }

        }

        public string Client
        {
            get => _client;
            set
            {
                _client = value;
                OnPropertyChanged(nameof(Client));
            }
        }

        public decimal GrossPrice
        {
            get => _grossPrice;
            set
            {
                _grossPrice = value;
                OnPropertyChanged(nameof(GrossPrice));
            }
        }

        public decimal NetPrice
        {
            get => _netPrice;
            set
            {
                _netPrice = value; 
                OnPropertyChanged(nameof(NetPrice));
            }
        }

        public int Amoud
        {
            get => _amoud;
            set
            {
                _amoud = value;
                OnPropertyChanged(nameof(Amoud));
            }
        }
    }

    public class BetaViewModel<TValue> : BasePropertyChanged
    {
        private TValue _value;
        private bool _isNotValid;
        private bool _isChanged;
        

        public TValue Value
        {
            get => _value;
            set
            {
                _value = value; 
                OnPropertyChanged(nameof(Value));
            }
        }

        public bool IsChanged
        {
            get => _isChanged;
            set
            {
                _isChanged = value;
                OnPropertyChanged(nameof(IsChanged));
            }
        }

        public bool IsNotValid
        {
            get => _isNotValid;
            set
            {
                _isNotValid = value;
                OnPropertyChanged(nameof(IsNotValid));
            }
        }

    }

    public class Document
    {
        public string Header { get; set; }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
    }
}
