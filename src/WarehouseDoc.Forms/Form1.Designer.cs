namespace WarehouseDoc.Forms
{

    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditHeader = new DevExpress.XtraEditors.TextEdit();
            this.textEditClient = new DevExpress.XtraEditors.TextEdit();
            this.textEditGrossPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEditNetPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEditAmoudPrice = new DevExpress.XtraEditors.TextEdit();
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmoud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrossPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNetPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmoudPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textEditHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textEditClient, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textEditGrossPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textEditNetPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textEditAmoudPrice, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(749, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Location = new System.Drawing.Point(4, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Header";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Location = new System.Drawing.Point(4, 49);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Client";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl3.Location = new System.Drawing.Point(4, 87);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Gross price";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Location = new System.Drawing.Point(4, 125);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Net price";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl5.Location = new System.Drawing.Point(4, 163);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Amoud";
            // 
            // textEditHeader
            // 
            this.textEditHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditHeader.Location = new System.Drawing.Point(76, 8);
            this.textEditHeader.Margin = new System.Windows.Forms.Padding(4);
            this.textEditHeader.Name = "textEditHeader";
            this.textEditHeader.Size = new System.Drawing.Size(172, 22);
            this.textEditHeader.TabIndex = 5;
            // 
            // textEditClient
            // 
            this.textEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditClient.Location = new System.Drawing.Point(76, 46);
            this.textEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.textEditClient.Name = "textEditClient";
            this.textEditClient.Size = new System.Drawing.Size(172, 22);
            this.textEditClient.TabIndex = 6;
            // 
            // textEditGrossPrice
            // 
            this.textEditGrossPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditGrossPrice.Location = new System.Drawing.Point(76, 84);
            this.textEditGrossPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textEditGrossPrice.Name = "textEditGrossPrice";
            this.textEditGrossPrice.Size = new System.Drawing.Size(172, 22);
            this.textEditGrossPrice.TabIndex = 7;
            // 
            // textEditNetPrice
            // 
            this.textEditNetPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNetPrice.Location = new System.Drawing.Point(76, 122);
            this.textEditNetPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textEditNetPrice.Name = "textEditNetPrice";
            this.textEditNetPrice.Size = new System.Drawing.Size(172, 22);
            this.textEditNetPrice.TabIndex = 8;
            // 
            // textEditAmoudPrice
            // 
            this.textEditAmoudPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditAmoudPrice.Location = new System.Drawing.Point(77, 160);
            this.textEditAmoudPrice.Margin = new System.Windows.Forms.Padding(5);
            this.textEditAmoudPrice.Name = "textEditAmoudPrice";
            this.textEditAmoudPrice.Size = new System.Drawing.Size(170, 22);
            this.textEditAmoudPrice.TabIndex = 9;
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.SnapControl = null;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnHeader,
            this.ColumnClient,
            this.ColumnGrossPrice,
            this.ColumnNetPrice,
            this.ColumnAmoud});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(693, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.Frozen = true;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnId.Width = 24;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DataPropertyName = "Header";
            this.ColumnHeader.Frozen = true;
            this.ColumnHeader.HeaderText = "Header";
            this.ColumnHeader.MinimumWidth = 6;
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.ReadOnly = true;
            this.ColumnHeader.Width = 120;
            // 
            // ColumnClient
            // 
            this.ColumnClient.DataPropertyName = "Client";
            this.ColumnClient.Frozen = true;
            this.ColumnClient.HeaderText = "Client";
            this.ColumnClient.MinimumWidth = 6;
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            this.ColumnClient.Width = 120;
            // 
            // ColumnGrossPrice
            // 
            this.ColumnGrossPrice.DataPropertyName = "GrossPrice";
            this.ColumnGrossPrice.Frozen = true;
            this.ColumnGrossPrice.HeaderText = "Gross price";
            this.ColumnGrossPrice.MinimumWidth = 6;
            this.ColumnGrossPrice.Name = "ColumnGrossPrice";
            this.ColumnGrossPrice.ReadOnly = true;
            this.ColumnGrossPrice.Width = 80;
            // 
            // ColumnNetPrice
            // 
            this.ColumnNetPrice.DataPropertyName = "NetPrice";
            this.ColumnNetPrice.Frozen = true;
            this.ColumnNetPrice.HeaderText = "Net price";
            this.ColumnNetPrice.MinimumWidth = 6;
            this.ColumnNetPrice.Name = "ColumnNetPrice";
            this.ColumnNetPrice.ReadOnly = true;
            this.ColumnNetPrice.Width = 80;
            // 
            // ColumnAmoud
            // 
            this.ColumnAmoud.DataPropertyName = "Amoud";
            this.ColumnAmoud.Frozen = true;
            this.ColumnAmoud.HeaderText = "Amoud";
            this.ColumnAmoud.MinimumWidth = 6;
            this.ColumnAmoud.Name = "ColumnAmoud";
            this.ColumnAmoud.ReadOnly = true;
            this.ColumnAmoud.Width = 50;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(21, 16);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 461);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 624);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrossPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNetPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmoudPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditHeader;
        private DevExpress.XtraEditors.TextEdit textEditClient;
        private DevExpress.XtraEditors.TextEdit textEditGrossPrice;
        private DevExpress.XtraEditors.TextEdit textEditNetPrice;
        private DevExpress.XtraEditors.TextEdit textEditAmoudPrice;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrossPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmoud;
    }
}

