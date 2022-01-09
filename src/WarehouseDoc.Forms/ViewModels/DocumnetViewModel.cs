namespace WarehouseDoc.Forms.ViewModels
{
    public class DocumnetViewModel : BasePropertyChanged
    {
        public int Id { get; set; }

        public string Header { get; set; }

        public string Client { get; set; }

        public decimal GrossPrice { get; set; }

        public decimal NetPrice { get; set; }

        public int Amoud { get; set; }
    }
}
