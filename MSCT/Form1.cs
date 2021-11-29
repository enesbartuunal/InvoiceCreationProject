using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        MSCTEntities db = new MSCTEntities();

        public string mK
        {
            get { return tbMusteriKodu.Text; }
            set { tbMusteriKodu.Text = value; }
        }

        public string mI
        {
            get { return tbMusteriAdi.Text; }
            set { tbMusteriAdi.Text = value; }
        }


        public string[] parabirimi = new string[]
        {
            "Tl",
            "Euro",
            "Usd"
        };

        public string[] siparisturu = new string[]
        {
            "N",
            "G"
        };

        public int n;

        public string malzemeKodu
        {
            get { return dataGridView1.Rows[n - 1].Cells[1].Value.ToString(); }
            set { dataGridView1.Rows[n - 1].Cells[1].Value = value; }
        }

        public string malzemeAdı
        {
            get { return dataGridView1.Rows[n - 1].Cells[2].Value.ToString(); }
            set { dataGridView1.Rows[n - 1].Cells[2].Value = value; }
        }

        public string stoklamOlcuBirimi
        {
            get { return dataGridView1.Rows[n - 1].Cells[4].Value.ToString(); }
            set { dataGridView1.Rows[n - 1].Cells[4].Value = value; }
        }

        public string vergiOranı
        {
            get
            {
                if (dataGridView1.Rows[n - 1].Cells[8].Value != null)
                    return dataGridView1.Rows[n - 1].Cells[8].Value.ToString();
                else
                    return "0";
            }
            set { dataGridView1.Rows[n - 1].Cells[8].Value = value; }
        }

        public string miktar
        {
            get
            {
                if (dataGridView1.Rows[n - 1].Cells[3].Value != null)
                    return dataGridView1.Rows[n - 1].Cells[3].Value.ToString();
                else
                    return "0";
            }
            set { dataGridView1.Rows[n - 1].Cells[3].Value = value; }
        }

        public string birimFiyatı
        {
            get
            {
                if (dataGridView1.Rows[n - 1].Cells[5].Value != null)
                    return dataGridView1.Rows[n - 1].Cells[5].Value.ToString();
                else
                    return "0";
            }
            set { dataGridView1.Rows[n - 1].Cells[5].Value = value; }
        }

        public string vergitutarı
        {
            get
            {
                if (dataGridView1.Rows[n - 1].Cells[6].Value != null)
                    return dataGridView1.Rows[n - 1].Cells[6].Value.ToString();
                else
                    return "0";
            }
            set { dataGridView1.Rows[n - 1].Cells[6].Value = value; }
        }

        public string netTutar
        {
            get
            {
                if (dataGridView1.Rows[n - 1].Cells[7].Value != null)
                    return dataGridView1.Rows[n - 1].Cells[7].Value.ToString();
                else
                    return "0";
            }
            set { dataGridView1.Rows[n - 1].Cells[7].Value = value; }
        }

        public string sipariskodu = "";
        public string siparisTuru = "";
        public string siparistarihi = "";
        public string musteriKodu = "";
        public string musteriAdı = "";
        public string parabirimiSt = "";
        public string toplamtutar = "";




        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            tbMusteriAdi.Enabled = false;
            tbMusteriKodu.Enabled = false;
            label9.Visible = false;
            textBox3.Visible = false;
            label8.Visible = false;
            //Tarih
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            //Tarih

            //ParaBirimi
            comboBox2.Items.AddRange(parabirimi);
            comboBox2.SelectedIndex = 0;
            //ParaBirimi

            //SiparisTürü
            comboBox1.Items.AddRange(siparisturu);
            comboBox1.SelectedIndex = 0;
            //SiparisTürü

            sipariskodu = textBox1.Text;
            siparisTuru = comboBox1.Text;
            siparistarihi = dateTimePicker1.Text;
            musteriKodu = tbMusteriKodu.Text;
            musteriAdı = tbMusteriAdi.Text;
            parabirimiSt = comboBox2.Text;
            toplamtutar = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MusteriPage m = new MusteriPage();

            m.TopMost = true;
            m.BringToFront();
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(385, 190);
            m.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();

            if (n == 0)
                n = 1;
            else if (n >= 1)
                n = n + 1;

            MalzemePage k = new MalzemePage();
            k.Focus();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SiparisPage s = new SiparisPage();
            s.Focus();
            s.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            tbMusteriAdi.Text = "";
            tbMusteriKodu.Text = "";
            dateTimePicker1.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (n != 0)
            {
                var b = float.Parse(birimFiyatı);
                var m = float.Parse(miktar);

                var v = float.Parse("0." + vergiOranı);

                vergitutarı = (b * m * v).ToString();
                netTutar = (b * m + b * m * v).ToString();
                float sum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value != null)
                    {
                        if (textBox3.Text == null || textBox3.Text == "")
                            sum += float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        else
                        {
                            sum += float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                            sum = sum / float.Parse(textBox3.Text);
                        }
                    }
                }
                if (comboBox1.SelectedIndex == 0)
                    textBox2.Text = sum.ToString() + " " + comboBox2.Text;
                else
                    textBox2.Text = "0";

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label9.Visible = false;
                textBox3.Visible = false;
                label8.Visible = false;
            }
            else
            {
                label9.Visible = true;
                textBox3.Visible = true;
                label8.Visible = true;
            }
        }
    }
}
