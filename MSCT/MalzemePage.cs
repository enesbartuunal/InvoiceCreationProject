using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSCT
{
    public partial class MalzemePage : Form
    {
        public MalzemePage()
        {
            InitializeComponent();
        }
        MSCTEntities db = new MSCTEntities();
        private void MalzemePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSCTDataSet9.Malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter1.Fill(this.mSCTDataSet9.Malzeme);
            // TODO: This line of code loads data into the 'mSCTDataSet7.Malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter.Fill(this.mSCTDataSet7.Malzeme);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var s = Convert.ToInt16(textBox1.Text);
                dataGridView1.DataSource = db.Malzemes.Where(q => q.MalzemeKodu == s).ToList();

            }
            else if (textBox1.Text == "")
            {
                this.malzemeTableAdapter.Fill(this.mSCTDataSet7.Malzeme);
            }
            else
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz!");
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Malzemes.Where(q => q.MalzemeAdi.StartsWith(textBox2.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f;
            var openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == "Form1");
            if (openForm == null)
                f = new Form1();
            else
                f = (Form1)openForm;
                       
            f.malzemeAdı = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.malzemeKodu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.vergiOranı =dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.stoklamOlcuBirimi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           

            f.Focus();
            f.Show();
            this.Dispose();
        }
    }
}
