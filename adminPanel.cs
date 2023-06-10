using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        private void adminPanel_Load(object sender, EventArgs e)
        {
            opacity(groupBox1, 128);
        }
        private void opacity(GroupBox groupBox, int opacity)
        {

            groupBox.BackColor = Color.FromArgb(opacity, groupBox.BackColor);

        }

        private void btnCostumerList_Click(object sender, EventArgs e)
        {
            Musteriler musterileriListe = new Musteriler();
            musterileriListe.Show();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            musteriAra mAra = new musteriAra();
            mAra.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            musteriOlustur mOlustur = new musteriOlustur(); 
            mOlustur.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriDuzenle mDuzenle = new musteriDuzenle();
            mDuzenle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriSil mSil = new musteriSil();
            mSil.Show();
        }
    }
}
