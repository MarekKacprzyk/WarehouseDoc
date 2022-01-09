using System.Collections.ObjectModel;
using DevExpress.XtraEditors;
using WarehouseDoc.Forms.ViewModels;

namespace WarehouseDoc.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private ObservableCollection<AlphaViewModel> _col;
        public Form1()
        {
            InitializeComponent();

            var data = new List<AlphaViewModel>()
            {
                new AlphaViewModel { Id = 1, Header = "Doc1", Client = "Marek", NetPrice = 122, GrossPrice = 100, Amoud = 4 },
                new AlphaViewModel { Id = 2, Header = "Doc2", Client = "Karol", NetPrice = 122, GrossPrice = 100, Amoud = 3 },
                new AlphaViewModel { Id = 3, Header = "Doc3", Client = "Wojtek", NetPrice = 122, GrossPrice = 100, Amoud = 5 },
            };
            _col = new ObservableCollection<AlphaViewModel>(data);
            
        }

        public void BindManager(Manager manager)
        {
            var source = new BindingSource();
            source.DataSource = manager.Source;
            dataGridView1.DataSource = source;
            dataGridView1.SelectionChanged += (_, e) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    manager.SelectedItem = dataGridView1.SelectedRows[0].DataBoundItem as AlphaViewModel;
                }
            };

            BindTextBox(textEditHeader, manager, nameof(manager.Header));
            BindTextBox(textEditClient, manager, nameof(manager.Client));
            BindTextBox(textEditNetPrice, manager, nameof(manager.NetPrice));
            BindTextBox(textEditGrossPrice, manager, nameof(manager.GrossPrice)); 
            BindTextBox(textEditAmoudPrice, manager, nameof(manager.Amoud));
        }

        private static void BindTextBox(BaseEdit control, object model, string modelPropertyName)
        {
            control.DataBindings.Add(nameof(control.EditValue), model, modelPropertyName, false,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
