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
    public partial class MusteriPage : Form
    {
        public MusteriPage()
        {
            InitializeComponent();
        }



        private void MusteriPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSCTDataSet.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.mSCTDataSet.Musteri);


        }

        public void dgMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 f;
            var openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == "Form1");
            if (openForm == null)
                f = new Form1();
            else
                f = (Form1)openForm;
            f.mK = dgMusteri.CurrentRow.Cells[0].Value.ToString();
            f.mI = dgMusteri.CurrentRow.Cells[1].Value.ToString();
            f.Focus();
            f.Show();
            this.Dispose();
        }
    }


}

