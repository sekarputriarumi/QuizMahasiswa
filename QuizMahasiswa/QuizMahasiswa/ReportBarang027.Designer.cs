namespace QuizMahasiswa
{
    partial class ReportBarang027
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
            this.ExportExcel = new System.Windows.Forms.Button();
            this.ExportPDF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qUIZMAHASISWADataSet = new QuizMahasiswa.QUIZMAHASISWADataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new QuizMahasiswa.QUIZMAHASISWADataSetTableAdapters.tbl_barangTableAdapter();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZMAHASISWADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportExcel
            // 
            this.ExportExcel.Location = new System.Drawing.Point(436, 35);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(150, 25);
            this.ExportExcel.TabIndex = 5;
            this.ExportExcel.Text = "Export into Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // ExportPDF
            // 
            this.ExportPDF.Location = new System.Drawing.Point(266, 35);
            this.ExportPDF.Name = "ExportPDF";
            this.ExportPDF.Size = new System.Drawing.Size(150, 25);
            this.ExportPDF.TabIndex = 4;
            this.ExportPDF.Text = "Export into PDF";
            this.ExportPDF.UseVisualStyleBackColor = true;
            this.ExportPDF.Click += new System.EventHandler(this.ExportPDF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 336);
            this.dataGridView1.TabIndex = 3;
            // 
            // qUIZMAHASISWADataSet
            // 
            this.qUIZMAHASISWADataSet.DataSetName = "QUIZMAHASISWADataSet";
            this.qUIZMAHASISWADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.qUIZMAHASISWADataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Nama Supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            // 
            // ReportBarang027
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.ExportPDF);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportBarang027";
            this.Text = "ReportBarang027";
            this.Load += new System.EventHandler(this.ReportBarang027_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZMAHASISWADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportExcel;
        private System.Windows.Forms.Button ExportPDF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QUIZMAHASISWADataSet qUIZMAHASISWADataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private QUIZMAHASISWADataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
    }
}