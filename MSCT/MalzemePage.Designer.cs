
namespace MSCT
{
    partial class MalzemePage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mSCTDataSet7 = new MSCT.MSCTDataSet7();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malzemeTableAdapter = new MSCT.MSCTDataSet7TableAdapters.MalzemeTableAdapter();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklamaOlcuBirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mSCTDataSet9 = new MSCT.MSCTDataSet9();
            this.malzemeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.malzemeTableAdapter1 = new MSCT.MSCTDataSet9TableAdapters.MalzemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeTuruDataGridViewTextBoxColumn,
            this.vergiOraniDataGridViewTextBoxColumn,
            this.stoklamaOlcuBirimiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mSCTDataSet7
            // 
            this.mSCTDataSet7.DataSetName = "MSCTDataSet7";
            this.mSCTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataMember = "Malzeme";
            this.malzemeBindingSource.DataSource = this.mSCTDataSet7;
            // 
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // malzemeKoduDataGridViewTextBoxColumn
            // 
            this.malzemeKoduDataGridViewTextBoxColumn.DataPropertyName = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.HeaderText = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.Name = "malzemeKoduDataGridViewTextBoxColumn";
            this.malzemeKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // malzemeTuruDataGridViewTextBoxColumn
            // 
            this.malzemeTuruDataGridViewTextBoxColumn.DataPropertyName = "MalzemeTuru";
            this.malzemeTuruDataGridViewTextBoxColumn.HeaderText = "MalzemeTuru";
            this.malzemeTuruDataGridViewTextBoxColumn.Name = "malzemeTuruDataGridViewTextBoxColumn";
            // 
            // vergiOraniDataGridViewTextBoxColumn
            // 
            this.vergiOraniDataGridViewTextBoxColumn.DataPropertyName = "VergiOrani";
            this.vergiOraniDataGridViewTextBoxColumn.HeaderText = "VergiOrani";
            this.vergiOraniDataGridViewTextBoxColumn.Name = "vergiOraniDataGridViewTextBoxColumn";
            // 
            // stoklamaOlcuBirimiDataGridViewTextBoxColumn
            // 
            this.stoklamaOlcuBirimiDataGridViewTextBoxColumn.DataPropertyName = "StoklamaOlcuBirimi";
            this.stoklamaOlcuBirimiDataGridViewTextBoxColumn.HeaderText = "StoklamaOlcuBirimi";
            this.stoklamaOlcuBirimiDataGridViewTextBoxColumn.Name = "stoklamaOlcuBirimiDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Malzeme Kodu ile ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Malzeme Adı ile ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mSCTDataSet9
            // 
            this.mSCTDataSet9.DataSetName = "MSCTDataSet9";
            this.mSCTDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemeBindingSource1
            // 
            this.malzemeBindingSource1.DataMember = "Malzeme";
            this.malzemeBindingSource1.DataSource = this.mSCTDataSet9;
            // 
            // malzemeTableAdapter1
            // 
            this.malzemeTableAdapter1.ClearBeforeFill = true;
            // 
            // MalzemePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MalzemePage";
            this.Text = "MalzemePage";
            this.Load += new System.EventHandler(this.MalzemePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MSCTDataSet7 mSCTDataSet7;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private MSCTDataSet7TableAdapters.MalzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoklamaOlcuBirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private MSCTDataSet9 mSCTDataSet9;
        private System.Windows.Forms.BindingSource malzemeBindingSource1;
        private MSCTDataSet9TableAdapters.MalzemeTableAdapter malzemeTableAdapter1;
    }
}