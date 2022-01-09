namespace WarehouseDoc.Forms.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class AlphaViewModel : BasePropertyChanged
    {
        public int Id { get; set; }

        public string Header { get; set; }

        public string Client { get; set; }

        public decimal GrossPrice { get; set; }

        public decimal NetPrice { get; set; }

        public int Amoud { get; set; }
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
