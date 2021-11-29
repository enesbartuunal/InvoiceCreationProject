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
    public partial class SiparisPage : Form
    {
        public SiparisPage()
        {
            InitializeComponent();
        }

        private void SiparisPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSCTDataSet1.SiparisBaslik' table. You can move, or remove it, as needed.
            this.siparisBaslikTableAdapter.Fill(this.mSCTDataSet1.SiparisBaslik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.sipariskodu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.siparisTuru = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.siparistarihi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.musteriAdı = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            form.toplamtutar = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.parabirimiSt = dataGridView1.CurrentRow.Cells[5].Value.ToString();


        }
    }
}
