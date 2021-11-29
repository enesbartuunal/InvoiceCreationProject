
namespace MSCT
{
    partial class MusteriPage
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
            this.dgMusteri = new System.Windows.Forms.DataGridView();
            this.musteriKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterriAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozelFıyatListesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSCTDataSet = new MSCT.MSCTDataSet();
            this.musteriTableAdapter = new MSCT.MSCTDataSetTableAdapters.MusteriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMusteri
            // 
            this.dgMusteri.AutoGenerateColumns = false;
            this.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriKoduDataGridViewTextBoxColumn,
            this.musterriAdıDataGridViewTextBoxColumn,
            this.musteriTuruDataGridViewTextBoxColumn,
            this.ozelFıyatListesiDataGridViewTextBoxColumn});
            this.dgMusteri.DataSource = this.musteriBindingSource;
            this.dgMusteri.Location = new System.Drawing.Point(40, 51);
            this.dgMusteri.Name = "dgMusteri";
            this.dgMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMusteri.Size = new System.Drawing.Size(447, 238);
            this.dgMusteri.TabIndex = 0;
            this.dgMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusteri_CellDoubleClick);
            // 
            // musteriKoduDataGridViewTextBoxColumn
            // 
            this.musteriKoduDataGridViewTextBoxColumn.DataPropertyName = "MusteriKodu";
            this.musteriKoduDataGridViewTextBoxColumn.HeaderText = "MusteriKodu";
            this.musteriKoduDataGridViewTextBoxColumn.Name = "musteriKoduDataGridViewTextBoxColumn";
            this.musteriKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musterriAdıDataGridViewTextBoxColumn
            // 
            this.musterriAdıDataGridViewTextBoxColumn.DataPropertyName = "MusterriAdı";
            this.musterriAdıDataGridViewTextBoxColumn.HeaderText = "MusterriAdı";
            this.musterriAdıDataGridViewTextBoxColumn.Name = "musterriAdıDataGridViewTextBoxColumn";
            // 
            // musteriTuruDataGridViewTextBoxColumn
            // 
            this.musteriTuruDataGridViewTextBoxColumn.DataPropertyName = "MusteriTuru";
            this.musteriTuruDataGridViewTextBoxColumn.HeaderText = "MusteriTuru";
            this.musteriTuruDataGridViewTextBoxColumn.Name = "musteriTuruDataGridViewTextBoxColumn";
            // 
            // ozelFıyatListesiDataGridViewTextBoxColumn
            // 
            this.ozelFıyatListesiDataGridViewTextBoxColumn.DataPropertyName = "OzelFıyatListesi";
            this.ozelFıyatListesiDataGridViewTextBoxColumn.HeaderText = "OzelFıyatListesi";
            this.ozelFıyatListesiDataGridViewTextBoxColumn.Name = "ozelFıyatListesiDataGridViewTextBoxColumn";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.mSCTDataSet;
            // 
            // mSCTDataSet
            // 
            this.mSCTDataSet.DataSetName = "MSCTDataSet";
            this.mSCTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMusteri);
            this.Name = "MusteriPage";
            this.Text = "MusteriPage";
            this.Load += new System.EventHandler(this.MusteriPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMusteri;
        private MSCTDataSet mSCTDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private MSCTDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterriAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozelFıyatListesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}