using System.Collections.ObjectModel;
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
            dataGridView1.DataSource = _col;
            lookUpEdit1.Properties.DataSource = _col;

            lookUpEdit1.EditValue = _col.First();
            lookUpEdit1.EditValueChanged += (_, e) =>
            {
                var qq = lookUpEdit1.EditValue;
            };

            dataGridView1.SelectionChanged += (_, e) =>
            {
                var qq = dataGridView1.SelectedCells;
                var ww = dataGridView1.SelectedRows;
                var aa = dataGridView1.SelectedColumns;
                var ss = dataGridView1.SelectionMode;

                var qq1 = dataGridView1.SelectedCells.Count;
                var ww1 = dataGridView1.SelectedRows.Count;
                var ww12 = dataGridView1.SelectedRows;
                var aa1 = dataGridView1.SelectedColumns.Count;
            };
        }
    }
}
