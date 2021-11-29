
namespace MSCT
{
    partial class SiparisPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisBaslikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSCTDataSet1 = new MSCT.MSCTDataSet1();
            this.siparisBaslikTableAdapter = new MSCT.MSCTDataSet1TableAdapters.SiparisBaslikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.siparisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraBirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBaslikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisNoDataGridViewTextBoxColumn,
            this.siparisTuruDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.paraBirimiDataGridViewTextBoxColumn,
            this.kalemNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparisBaslikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // siparisBaslikBindingSource
            // 
            this.siparisBaslikBindingSource.DataMember = "SiparisBaslik";
            this.siparisBaslikBindingSource.DataSource = this.mSCTDataSet1;
            // 
            // mSCTDataSet1
            // 
            this.mSCTDataSet1.DataSetName = "MSCTDataSet1";
            this.mSCTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBaslikTableAdapter
            // 
            this.siparisBaslikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siparisNoDataGridViewTextBoxColumn
            // 
            this.siparisNoDataGridViewTextBoxColumn.DataPropertyName = "SiparisNo";
            this.siparisNoDataGridViewTextBoxColumn.HeaderText = "SiparisNo";
            this.siparisNoDataGridViewTextBoxColumn.Name = "siparisNoDataGridViewTextBoxColumn";
            this.siparisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTuruDataGridViewTextBoxColumn
            // 
            this.siparisTuruDataGridViewTextBoxColumn.DataPropertyName = "SiparisTuru";
            this.siparisTuruDataGridViewTextBoxColumn.HeaderText = "SiparisTuru";
            this.siparisTuruDataGridViewTextBoxColumn.Name = "siparisTuruDataGridViewTextBoxColumn";
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // paraBirimiDataGridViewTextBoxColumn
            // 
            this.paraBirimiDataGridViewTextBoxColumn.DataPropertyName = "ParaBirimi";
            this.paraBirimiDataGridViewTextBoxColumn.HeaderText = "ParaBirimi";
            this.paraBirimiDataGridViewTextBoxColumn.Name = "paraBirimiDataGridViewTextBoxColumn";
            this.paraBirimiDataGridViewTextBoxColumn.Visible = false;
            // 
            // kalemNoDataGridViewTextBoxColumn
            // 
            this.kalemNoDataGridViewTextBoxColumn.DataPropertyName = "KalemNo";
            this.kalemNoDataGridViewTextBoxColumn.HeaderText = "KalemNo";
            this.kalemNoDataGridViewTextBoxColumn.Name = "kalemNoDataGridViewTextBoxColumn";
            this.kalemNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // SiparisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SiparisPage";
            this.Text = "SiparisPage";
            this.Load += new System.EventHandler(this.SiparisPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBaslikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MSCTDataSet1 mSCTDataSet1;
        private System.Windows.Forms.BindingSource siparisBaslikBindingSource;
        private MSCTDataSet1TableAdapters.SiparisBaslikTableAdapter siparisBaslikTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraBirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalemNoDataGridViewTextBoxColumn;
    }
}