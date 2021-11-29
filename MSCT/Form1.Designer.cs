
namespace MSCT
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KalemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MazlemeAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MalzemeKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoklamaOlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiTutarı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiOran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisKalemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mSCTDataSet8 = new MSCT.MSCTDataSet8();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMusteriKodu = new System.Windows.Forms.TextBox();
            this.tbMusteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mSCTDataSet3 = new MSCT.MSCTDataSet3();
            this.siparisKalemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisKalemTableAdapter = new MSCT.MSCTDataSet3TableAdapters.SiparisKalemTableAdapter();
            this.mSCTDataSet4 = new MSCT.MSCTDataSet4();
            this.siparisKalemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisKalemTableAdapter1 = new MSCT.MSCTDataSet4TableAdapters.SiparisKalemTableAdapter();
            this.mSCTDataSet5 = new MSCT.MSCTDataSet5();
            this.siparisKalemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisKalemTableAdapter2 = new MSCT.MSCTDataSet5TableAdapters.SiparisKalemTableAdapter();
            this.siparisKalemTableAdapter3 = new MSCT.MSCTDataSet8TableAdapters.SiparisKalemTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KalemNo,
            this.MazlemeAdı,
            this.MalzemeKodu,
            this.Miktar,
            this.StoklamaOlcuBirimi,
            this.BirimFiyat,
            this.VergiTutarı,
            this.NetTutar,
            this.VergiOran});
            this.dataGridView1.Location = new System.Drawing.Point(38, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // KalemNo
            // 
            this.KalemNo.HeaderText = "KalemNo";
            this.KalemNo.Name = "KalemNo";
            this.KalemNo.ReadOnly = true;
            this.KalemNo.Visible = false;
            // 
            // MazlemeAdı
            // 
            this.MazlemeAdı.HeaderText = "Malzeme ";
            this.MazlemeAdı.Name = "MazlemeAdı";
            this.MazlemeAdı.ReadOnly = true;
            // 
            // MalzemeKodu
            // 
            this.MalzemeKodu.HeaderText = "MalzemeKodu";
            this.MalzemeKodu.Name = "MalzemeKodu";
            this.MalzemeKodu.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // StoklamaOlcuBirimi
            // 
            this.StoklamaOlcuBirimi.HeaderText = "Ölçü Birimi";
            this.StoklamaOlcuBirimi.Name = "StoklamaOlcuBirimi";
            this.StoklamaOlcuBirimi.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Brim Fiyatı";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // VergiTutarı
            // 
            this.VergiTutarı.HeaderText = "Toplam Vergi Tutarı";
            this.VergiTutarı.Name = "VergiTutarı";
            this.VergiTutarı.ReadOnly = true;
            // 
            // NetTutar
            // 
            this.NetTutar.HeaderText = "Net Tutar:";
            this.NetTutar.Name = "NetTutar";
            this.NetTutar.ReadOnly = true;
            // 
            // VergiOran
            // 
            this.VergiOran.HeaderText = "Vergi Oranı";
            this.VergiOran.Name = "VergiOran";
            // 
            // siparisKalemBindingSource3
            // 
            this.siparisKalemBindingSource3.DataMember = "SiparisKalem";
            this.siparisKalemBindingSource3.DataSource = this.mSCTDataSet8;
            // 
            // mSCTDataSet8
            // 
            this.mSCTDataSet8.DataSetName = "MSCTDataSet8";
            this.mSCTDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Siparis No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Siparis Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Siparis Tarihi:";
            // 
            // tbMusteriKodu
            // 
            this.tbMusteriKodu.Location = new System.Drawing.Point(462, 63);
            this.tbMusteriKodu.Name = "tbMusteriKodu";
            this.tbMusteriKodu.Size = new System.Drawing.Size(121, 20);
            this.tbMusteriKodu.TabIndex = 1;
            // 
            // tbMusteriAdi
            // 
            this.tbMusteriAdi.Location = new System.Drawing.Point(462, 92);
            this.tbMusteriAdi.Name = "tbMusteriAdi";
            this.tbMusteriAdi.Size = new System.Drawing.Size(119, 20);
            this.tbMusteriAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müsteri Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müsteri Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Para Birimi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(462, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(38, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Kalem Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(760, 413);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // mSCTDataSet3
            // 
            this.mSCTDataSet3.DataSetName = "MSCTDataSet3";
            this.mSCTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisKalemBindingSource
            // 
            this.siparisKalemBindingSource.DataMember = "SiparisKalem";
            this.siparisKalemBindingSource.DataSource = this.mSCTDataSet3;
            // 
            // siparisKalemTableAdapter
            // 
            this.siparisKalemTableAdapter.ClearBeforeFill = true;
            // 
            // mSCTDataSet4
            // 
            this.mSCTDataSet4.DataSetName = "MSCTDataSet4";
            this.mSCTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisKalemBindingSource1
            // 
            this.siparisKalemBindingSource1.DataMember = "SiparisKalem";
            this.siparisKalemBindingSource1.DataSource = this.mSCTDataSet4;
            // 
            // siparisKalemTableAdapter1
            // 
            this.siparisKalemTableAdapter1.ClearBeforeFill = true;
            // 
            // mSCTDataSet5
            // 
            this.mSCTDataSet5.DataSetName = "MSCTDataSet5";
            this.mSCTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisKalemBindingSource2
            // 
            this.siparisKalemBindingSource2.DataMember = "SiparisKalem";
            this.siparisKalemBindingSource2.DataSource = this.mSCTDataSet5;
            // 
            // siparisKalemTableAdapter2
            // 
            this.siparisKalemTableAdapter2.ClearBeforeFill = true;
            // 
            // siparisKalemTableAdapter3
            // 
            this.siparisKalemTableAdapter3.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Toplam Tutar:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(462, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(509, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Lütfen tl dısında girdiğiniz parabiriminin Tl karşılığını ondalık kısmını \'.\' ile" +
    " belirtecek şekilde giriniz(Örnek:8.78)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 527);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbMusteriAdi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbMusteriKodu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSCTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKalemBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMusteriKodu;
        private System.Windows.Forms.TextBox tbMusteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MSCTDataSet3 mSCTDataSet3;
        private System.Windows.Forms.BindingSource siparisKalemBindingSource;
        private MSCTDataSet3TableAdapters.SiparisKalemTableAdapter siparisKalemTableAdapter;
        private MSCTDataSet4 mSCTDataSet4;
        private System.Windows.Forms.BindingSource siparisKalemBindingSource1;
        private MSCTDataSet4TableAdapters.SiparisKalemTableAdapter siparisKalemTableAdapter1;
        private MSCTDataSet5 mSCTDataSet5;
        private System.Windows.Forms.BindingSource siparisKalemBindingSource2;
        private MSCTDataSet5TableAdapters.SiparisKalemTableAdapter siparisKalemTableAdapter2;
        private MSCTDataSet8 mSCTDataSet8;
        private System.Windows.Forms.BindingSource siparisKalemBindingSource3;
        private MSCTDataSet8TableAdapters.SiparisKalemTableAdapter siparisKalemTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MazlemeAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn MalzemeKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoklamaOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiTutarı;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiOran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

